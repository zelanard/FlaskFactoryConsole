namespace FlaskFactoryConsole.Model.FactoryControls
{
    /// <summary>
    /// Defines the functionality for an object that can push flasks into a buffer or processing line.
    /// </summary>
    public interface IPusher
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        void Push(object obj);
    }
}
