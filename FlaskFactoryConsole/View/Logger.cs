using System;

namespace FlaskFactoryConsole.View
{
	/// <summary>
	/// Provides logging functionality for the factory.
	/// </summary>
	public static class Logger
	{
		/// <summary>
		/// Logs the production of a flask.
		/// </summary>
		/// <param name="flaskType">The type of the flask produced.</param>
		/// <param name="id">The ID of the flask produced.</param>
		public static void LogProduction(string flaskType, int id)
		{
			SetColor(flaskType);
			Console.WriteLine($"Produced: {flaskType}, ID: {id}");
			Console.ResetColor();
		}

		/// <summary>
		/// Logs the splitting of a flask to a belt.
		/// </summary>
		/// <param name="flaskType">The type of the flask split.</param>
		/// <param name="id">The ID of the flask split.</param>
		/// <param name="belt">The belt to which the flask was sent.</param>
		public static void LogSplitting(string flaskType, int id, string belt)
		{
			SetColor(flaskType);
			Console.WriteLine($"Sent to {belt}: {flaskType}, ID: {id}");
			Console.ResetColor();
		}

		/// <summary>
		/// Logs the consumption of a flask.
		/// </summary>
		/// <param name="title">The title of the consumer.</param>
		/// <param name="flaskType">The type of the flask consumed.</param>
		/// <param name="id">The ID of the flask consumed.</param>
		public static void LogConsumption(string title, string flaskType, int id)
		{
			SetColor(flaskType);
			Console.WriteLine($"{title} Consumed: {flaskType}, ID: {id}");
			Console.ResetColor();
		}

		/// <summary>
		/// Sets the console color based on the type of the flask.
		/// </summary>
		/// <param name="flaskType">The type of the flask.</param>
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
