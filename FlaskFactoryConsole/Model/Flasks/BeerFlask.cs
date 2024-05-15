using System;

namespace FlaskFactoryConsole.Model.Flasks
{
    /// <summary>
    /// Represents a beer flask which is a specific type of flask designed to hold beer.
    /// </summary>
    public class BeerFlask : Flask
    {
        private ConsoleColor color = ConsoleColor.Green;

        /// <summary>
        /// Initializes a new instance of the BeerFlask class with the specified identifier.
        /// </summary>
        /// <param name="id">The unique identifier for the flask.</param>
        public BeerFlask(int id) : base(id)
        {
        }

        /// <summary>
        /// Returns a string that represents the current BeerFlask object.
        /// </summary>
        /// <returns>A string that represents the current BeerFlask object, including its color and ID.</returns>
        public override string ToString()
        {
            return $"A {color} Beer Flask: {ID}";
        }
    }
}
