using FlaskFactoryConsole.Model.FactoryControls;
using FlaskFactoryConsole.Model.Flasks;
using FlaskFactoryConsole.Utils;
using FlaskFactoryConsole.View;
using System.Threading;

namespace FlaskFactoryConsole.Model
{
    /// <summary>
    /// <c>Producer</c> models a flask producer.
    /// </summary>
	public class Producer : IPusher
	{
		/// <summary>
		/// The production belt where the producer places the flasks.
		/// </summary>
		public ConveyerBelt ProductionBelt;
		int FlasksProduced = 0;
		public Producer(ConveyerBelt productionBelt)
		{
			ProductionBelt = productionBelt;
		}

		/// <summary>
		/// The Push method adds a flask to the production belt if there is room.
		/// It also logs the production of the flask.
		/// </summary>
		/// <param name="flaskType">The type of flask to be produced.</param>
		public void Push(object flaskType)
		{
			if (ProductionBelt.Count < ConveyerBelt.MAX_SIZE)
			{
				FlasksProduced++;
				switch (flaskType)
				{
					case FlaskTypes.BeerFlask:
						ProductionBelt.Enqueue(new BeerFlask(FlasksProduced));
						Logger.LogProduction(FlaskTypes.BeerFlask.ToString(), FlasksProduced);
						break;
					case FlaskTypes.SodaFlask:
						ProductionBelt.Enqueue(new SodaFlask(FlasksProduced));
						Logger.LogProduction(FlaskTypes.SodaFlask.ToString(), FlasksProduced);
						break;
					default:
						break;
				}
			}
		}

		/// <summary>
		/// The Run method starts the production process.
		/// It alternates between producing beer and soda flasks.
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
				Thread.Sleep(0.2f.ToMiliseconds());
			}
		}
	}
}
