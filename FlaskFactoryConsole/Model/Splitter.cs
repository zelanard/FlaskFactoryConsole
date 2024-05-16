using FlaskFactoryConsole.Model.FactoryControls;
using FlaskFactoryConsole.View;
using System.Threading;

namespace FlaskFactoryConsole.Utils
{
	/// <summary>
	/// The Splitter class is responsible for splitting the flasks from the production belt to the respective beer and soda belts.
	/// It inherits from the Consumer class and implements the IPusher interface.
	/// </summary>
	public class Splitter : Consumer, IPusher
	{
		ConveyerBelt BeerBelt;
		ConveyerBelt SodaBelt;

		/// <summary>
		/// Constructor for the Splitter class. Initializes the production, beer, and soda belts.
		/// </summary>
		/// <param name="productionBelt">The production belt where the flasks are produced.</param>
		/// <param name="beerBelt">The beer belt where the beer flasks are placed.</param>
		/// <param name="sodaBelt">The soda belt where the soda flasks are placed.</param>
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
		}
	}
}