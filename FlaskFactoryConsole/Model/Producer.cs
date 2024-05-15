using FlaskFactoryConsole.Model.FactoryControls;
using FlaskFactoryConsole.Model.Flasks;
using FlaskFactoryConsole.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlaskFactoryConsole.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Producer : IPusher
    {
        /// <summary>
        /// 
        /// </summary>
        public ConveyerBelt ProductionBelt;
        int FlasksProduced = 0;
        public Producer(ConveyerBelt productionBelt)
        {
            ProductionBelt = productionBelt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="flaskType"></param>
        public void Push(FlaskTypes flaskType)
        {
                if (ProductionBelt.Count < ConveyerBelt.MAX_SIZE)
                {
                    FlasksProduced++;
                    switch (flaskType)
                    {
                        case FlaskTypes.BeerFlask:
                            ProductionBelt.Enqueue(new BeerFlask(FlasksProduced));
                            break;
                        case FlaskTypes.SodaFlask:
                            ProductionBelt.Enqueue(new SodaFlask(FlasksProduced));
                            break;
                    }
                }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        internal void Run(object obj)
        {
            bool isBeer = false;
            while (true)
            {
                if (isBeer)
                {
                    Push(FlaskTypes.BeerFlask);
                }
                else
                {
                    Push(FlaskTypes.SodaFlask);
                }
                isBeer = !isBeer;
                Thread.Sleep(1.ToMiliseconds());
            }
        }
    }
}