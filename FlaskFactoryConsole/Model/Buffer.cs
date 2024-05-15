using FlaskFactoryConsole.Model.Flasks;
using System.Collections.Generic;

namespace FlaskFactoryConsole.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Buffer
    {
        public const int MAX_SIZE = 100;
        public Queue<Flask> flasks;
        
        /// <summary>
        /// 
        /// </summary>
        public Buffer()
        {
            flasks = new Queue<Flask>();
        }
    }
}
