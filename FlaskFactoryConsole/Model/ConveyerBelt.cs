using System.Collections.Generic;
using FlaskFactoryConsole.Model.Flasks;

namespace FlaskFactoryConsole.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public class ConveyerBelt
    {
        public const int MAX_SIZE = 100;
        private Queue<Flask> flasks;
        private readonly object lockObject = new object();

        /// <summary>
        /// 
        /// </summary>
        public ConveyerBelt()
        {
            flasks = new Queue<Flask>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(Flask item)
        {
            lock (lockObject)
            {
                if (flasks.Count < MAX_SIZE)
                {
                    flasks.Enqueue(item);
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
                return flasks.Count > 0 ? flasks.Dequeue() : null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Count
        {
            get
            {
                lock (lockObject)
                {
                    return flasks.Count;
                }
            }
        }
    }
}
