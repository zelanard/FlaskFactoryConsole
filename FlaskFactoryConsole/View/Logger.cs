using System;

namespace FlaskFactoryConsole.View
{
    /// <summary>
    /// handles the logging output.
    /// </summary>
    public static class Logger
    {
        /// <summary>
        /// Generate logmessage when producing flasks
        /// </summary>
        /// <param name="flaskType"></param>
        /// <param name="id"></param>
        public static void LogProduction(string flaskType, int id)
        {
            SetColor(flaskType);
            Console.WriteLine($"Produced: {flaskType}, ID: {id}");
            Console.ResetColor();
        }

        /// <summary>
        /// Generate Log message from splitting flasks.
        /// </summary>
        /// <param name="flaskType"></param>
        /// <param name="id"></param>
        /// <param name="belt"></param>
        public static void LogSplitting(string flaskType, int id, string belt)
        {
            SetColor(flaskType);
            Console.WriteLine($"Sent to {belt}: {flaskType}, ID: {id}");
            Console.ResetColor();
        }

		/// <summary>
		/// Generate log message for pulling of flasks
		/// </summary>
		/// <param name="flaskType"></param>
		/// <param name="id"></param>
		/// <param name="belt"></param>
        public static void LogPulling(string flaskType, int id, string belt)
        {
            SetColor(flaskType);
            Console.WriteLine($"Pulled from {belt}: {flaskType}, ID: {id}");
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
        /// Set the foregroundColor of the console.
        /// </summary>
        /// <param name="flaskType"></param>
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
