using FlaskFactoryConsole.Model;
using FlaskFactoryConsole.Utils;
using System;

namespace FlaskFactoryConsole.View
{
    public class EndConsumer : Consumer
    {
        public EndConsumer(ConveyerBelt buffer) : base(buffer) { }

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
