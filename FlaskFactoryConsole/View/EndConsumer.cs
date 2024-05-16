using FlaskFactoryConsole.Utils;

namespace FlaskFactoryConsole.View
{
    /// <summary>
    /// 
    /// </summary>
    public class EndConsumer : Consumer
    {
		private string Title;

        /// <summary>
        /// Initialzes a EndConsumer with the represented belt
		/// And gives the EndConsumer a Title
        /// </summary>
        /// <param name="buffer"></param>
        public EndConsumer(ConveyerBelt buffer, string title) : base(buffer) 
		{
			Title = title;
		}

		/// <summary>
		/// Writes the Title, Flask Type, Flask ID to the console
		/// </summary>
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
	}
}
