using FlaskFactoryConsole.Model.Flasks;
using System;

namespace FlaskFactoryConsole.Utils
{
	/// <summary>
	/// The FlaskExtensions class provides extension methods for the Flask class.
	/// </summary>
	public static class FlaskExtensions
	{
		/// <summary>
		/// The GetFlaskType method determines the type of a given flask.
		/// It returns the FlaskTypes enum value corresponding to the flask type.
		/// </summary>
		/// <param name="flask">The flask whose type is to be determined.</param>
		/// <returns>The type of the flask as a FlaskTypes enum value.</returns>
		/// <exception cref="NotImplementedException">Thrown when the flask type is not recognized.</exception>
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
