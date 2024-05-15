﻿using FlaskFactoryConsole.Model.Flasks;
using System;

namespace FlaskFactoryConsole.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public static class FlaskExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="flask"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
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