using FlaskFactoryConsole.Model.FactoryControls;
using FlaskFactoryConsole.Model.Flasks;

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
        /// 
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
        /// 
        /// </summary>
        /// <param name="flaskType"></param>
        public void Push(object obj)
        {
            if (CurrentFlask != null)
            {
                switch (CurrentFlask.GetFlaskType())
                {
                    case FlaskTypes.BeerFlask:
                        BeerBelt.Enqueue(CurrentFlask);
                        break;
                    case FlaskTypes.SodaFlask:
                        SodaBelt.Enqueue(CurrentFlask);
                        break;
                    default: 
                        break;
                }
                CurrentFlask = null;
            }
        }
    }
}