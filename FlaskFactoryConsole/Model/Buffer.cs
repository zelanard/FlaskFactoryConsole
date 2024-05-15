using System.Collections.Generic;
using FlaskFactoryConsole.Model.Flasks;

namespace FlaskFactoryConsole.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public class Buffer
    {
        public const int MAX_SIZE = 100;
        private Queue<Flask> buffer;
        private readonly object lockObject = new object();

        /// <summary>
        /// 
        /// </summary>
        public Buffer()
        {
            buffer = new Queue<Flask>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(Flask item)
        {
            lock (lockObject)
            {
                if (buffer.Count < MAX_SIZE)
                {
                    buffer.Enqueue(item);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Flask Dequeue()
        {
            lock (lockObject)
            {
                return buffer.Count > 0 ? buffer.Dequeue() : null;
            }
        }

        public int Count
        {
            get
            {
                lock (lockObject)
                {
                    return buffer.Count;
                }
            }
        }
    }
}
