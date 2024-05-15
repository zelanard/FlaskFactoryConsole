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
        public Queue<Flask> _flasks;
        
        /// <summary>
        /// 
        /// </summary>
        public Buffer()
        {
            _flasks = new Queue<Flask>();
        }
    }
}
