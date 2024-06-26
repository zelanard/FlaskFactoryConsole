﻿using FlaskFactoryConsole.Model.FactoryControls;
using FlaskFactoryConsole.View;
using System.Threading;

namespace FlaskFactoryConsole.Utils
{
    /// <summary>
    /// <c>Splitter</c> models a splitter. It pulls from one conveyerbelt and sort the flasks on the two other conveyer belts.
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

        public override void Pull(object obj)
        {
            {
                while (true)
                {
                    lock (this)
                    {
                        if (CurrentFlask == null && Buffer.Count > 0)
                        {
                            CurrentFlask = Buffer.Dequeue();
                            Logger.LogPulling(CurrentFlask.GetFlaskType().ToString(), CurrentFlask.ID, "Splitter");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 
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