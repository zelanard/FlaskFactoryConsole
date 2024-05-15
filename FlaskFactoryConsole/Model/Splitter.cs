using FlaskFactoryConsole.Model.FactoryControls;
using FlaskFactoryConsole.View;
using System.Threading;

namespace FlaskFactoryConsole.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public class Splitter : Consumer, IPusher
    {
        ConveyerBelt BeerBelt;
        ConveyerBelt SodaBelt;

        /// <summary>
        /// Initializes a new instances of the Splitter class with the specified belts required
        /// </summary>
        /// <param name="productionBelt"></param>
        /// <param name="beerBelt"></param>
        /// <param name="sodaBelt"></param>
        public Splitter(ConveyerBelt productionBelt, ConveyerBelt beerBelt, ConveyerBelt sodaBelt) : base(productionBelt)
        {
            BeerBelt = beerBelt;
            SodaBelt = sodaBelt;
        }

        /// <summary>
        /// Pushes the currentflask from the ProducerBelt into the represented belt
        /// </summary>
        /// <param name="flaskType"></param>
        public void Push(object obj)
        {
            while (true)
            {
                if (CurrentFlask != null)
                {
                    switch (CurrentFlask.GetFlaskType())
                    {
                        case FlaskTypes.BeerFlask:
                            BeerBelt.Enqueue(CurrentFlask);
                            Logger.LogSplitting(FlaskTypes.BeerFlask.ToString(), CurrentFlask.ID, "BeerBelt");
                            break;
                        case FlaskTypes.SodaFlask:
                            SodaBelt.Enqueue(CurrentFlask);
                            Logger.LogSplitting(FlaskTypes.SodaFlask.ToString(), CurrentFlask.ID, "SodaBelt");
                            break;
                        default:
                            break;
                    }
                    CurrentFlask = null;
                }
                Thread.Sleep(2f.ToMiliseconds());
            }
        }
    }
}