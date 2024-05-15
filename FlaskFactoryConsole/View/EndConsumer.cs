using FlaskFactoryConsole.Model;
using FlaskFactoryConsole.Utils;
using System;

namespace FlaskFactoryConsole.View
{
    /// <summary>
    /// 
    /// </summary>
    public class EndConsumer : Consumer
    {
		private string Title;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        public EndConsumer(ConveyerBelt buffer, string title) : base(buffer) 
		{
			Title = title;
		}

		/// <summary>
		/// 
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
