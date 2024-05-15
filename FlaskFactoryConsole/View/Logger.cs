// Logger.cs
using System;

namespace FlaskFactoryConsole.View
{
	public static class Logger
	{
		public static void LogProduction(string flaskType, int id)
		{
			SetColor(flaskType);
			Console.WriteLine($"Produced: {flaskType}, ID: {id}");
			Console.ResetColor();
		}

		public static void LogSplitting(string flaskType, int id, string belt)
		{
			SetColor(flaskType);
			Console.WriteLine($"Sent to {belt}: {flaskType}, ID: {id}");
			Console.ResetColor();
		}

		public static void LogConsumption(string flaskType, int id)
		{
			SetColor(flaskType);
			Console.WriteLine($"Consumed: {flaskType}, ID: {id}");
			Console.ResetColor();
		}

		private static void SetColor(string flaskType)
		{
			if (flaskType == "BeerFlask")
			{
				Console.ForegroundColor = ConsoleColor.Green;
			}
			else if (flaskType == "SodaFlask")
			{
				Console.ForegroundColor = ConsoleColor.White;
			}
		}
	}
}
