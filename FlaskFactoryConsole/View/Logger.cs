using System;

namespace FlaskFactoryConsole.View
{
    /// <summary>
    /// 
    /// </summary>
    public static class Logger
    {
        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="flaskType"></param>
        /// <param name="id"></param>
        public static void LogConsumption(string title, string flaskType, int id)
        {
            SetColor(flaskType);
            Console.WriteLine($"{title} Consumed: {flaskType}, ID: {id}");
            Console.ResetColor();
        }

        /// <summary>
        /// 
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
