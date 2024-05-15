namespace FlaskFactoryConsole.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public static class IntExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToMiliseconds(this int value)
        {
            return value * 10; // 1000 for default value, 10 to speed it up for debuggin' purposes
        }
    }
}
