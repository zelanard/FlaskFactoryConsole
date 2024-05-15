using FlaskFactoryConsole.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskFactoryConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            factory.Run();
        }
    }
}
