using FlaskFactoryConsole.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskFactoryConsole
{
	/// <summary>
	/// The main entry point for the application.
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// <param name="args">A list of command-line arguments.</param>
		static void Main(string[] args)
		{
			// Create a new factory
			Factory factory = new Factory();
			// Run the factory
			factory.Run();
		}
	}
}
