using System;

namespace FlaskFactoryConsole.Model.Flasks
{
    /// <summary>
    /// Represents a beer flask, designed specifically to hold beer.
    /// </summary>
    public class BeerFlask : Flask
    {
        private ConsoleColor color = ConsoleColor.Green;

        /// <summary>
        /// Initializes a new instance of the BeerFlask class with a specified identifier.
        /// </summary>
        public BeerFlask(int id) : base(id)
        {
        }

        /// <summary>
        /// Returns a string representation of the current BeerFlask object, including its color and ID.
        /// </summary>
        /// <returns>A string that represents the current BeerFlask object.</returns>
        public override string ToString()
        {
            return $"A {color} Beer Flask: {ID}";
        }
    }
}
