using FlaskFactoryConsole.Utils;

namespace FlaskFactoryConsole.View
{
	/// <summary>
	/// Represents an end consumer in the factory.
	/// </summary>
	public class EndConsumer : Consumer
	{
		private string Title;

		/// <summary>
		/// Initializes a new instance of the EndConsumer class with the specified conveyor belt and title.
		/// </summary>
		/// <param name="buffer">The conveyor belt that the end consumer will use.</param>
		/// <param name="title">The title of the end consumer.</param>
		public EndConsumer(ConveyerBelt buffer, string title) : base(buffer)
		{
			Title = title;
		}

		/// <summary>
		/// Prints the title, flask type, and flask ID to the console.
		/// </summary>
		/// <param name="obj">The object to print.</param>
		public void Print(object obj)
		{
			while (true)
			{
				if (CurrentFlask != null)
				{
					Logger.LogConsumption(Title, CurrentFlask.GetFlaskType().ToString(), CurrentFlask.ID);
					CurrentFlask = null;
				}
			}
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
                            Logger.LogPulling(CurrentFlask.GetFlaskType().ToString(), CurrentFlask.ID, Title);
                        }
                    }
                }
            }
        }
    }
}
