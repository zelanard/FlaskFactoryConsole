using System;

namespace FlaskFactoryConsole.Model.Flasks
{
    /// <summary>
    /// Represents a soda flask which is a specific type of flask.
    /// </summary>
    public class SodaFlask : Flask
    {
        private ConsoleColor color = ConsoleColor.White;

        /// <summary>
        /// Initializes a new instance of the SodaFlask class with the specified identifier.
        /// </summary>
        /// <param name="id">The unique identifier for the flask.</param>
        public SodaFlask(int id) : base(id)
        {
        }

        /// <summary>
        /// Returns a string that represents the current SodaFlask object.
        /// </summary>
        /// <returns>A string that represents the current SodaFlask object.</returns>
        public override string ToString()
        {
            return $"A {color} Soda Flask: {ID}";
        }
    }
}
