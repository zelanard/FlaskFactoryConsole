using System;

namespace FlaskFactoryConsole.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public static class NumberExtension
    {
        /// <summary>
        /// Converts the represented int value to miliseconds
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToMiliseconds(this int value)
        {
            return value * 1000;
        }

        /// <summary>
        /// Converts the represented float value to miliseconds
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToMiliseconds(this float value)
        {
            return Convert.ToInt32(value * 1000f);
        }
    }
}
