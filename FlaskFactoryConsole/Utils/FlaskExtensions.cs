using FlaskFactoryConsole.Model.Flasks;
using System;

namespace FlaskFactoryConsole.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public static class FlaskExtensions
    {
		/// <summary>
		/// Determines the type of the flask.
		/// </summary>
		/// <param name="flask">The flask whose type is to be determined.</param>
		/// <returns>The type of the flask.</returns>
		/// <exception cref="NotImplementedException">Thrown when the flask type is not supported.</exception>
		public static FlaskTypes GetFlaskType(this Flask flask)
        {
            switch (flask)
            {
                case BeerFlask beerFlask:
                    return FlaskTypes.BeerFlask;
                case SodaFlask sodaFlask:
                    return FlaskTypes.SodaFlask;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
