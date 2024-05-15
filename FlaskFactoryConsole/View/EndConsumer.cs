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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        public EndConsumer(ConveyerBelt buffer) : base(buffer) { }

        /// <summary>
        /// 
        /// </summary>
        public void Print()
        {
            if (CurrentFlask != null)
            {
                Console.WriteLine(CurrentFlask.ToString());
                CurrentFlask = null;
            }
        }
    }
}
