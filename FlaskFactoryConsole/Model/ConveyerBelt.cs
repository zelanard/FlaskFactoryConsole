using System.Collections.Generic;
using FlaskFactoryConsole.Model.Flasks;

namespace FlaskFactoryConsole.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public class ConveyerBelt
    {
        public const int MAX_SIZE = 99;
        private Queue<Flask> flasks;
        private readonly object lockObject = new object();

        /// <summary>
        /// Initializes the ConveyerBelt and initializing the queue
        /// </summary>
        public ConveyerBelt()
        {
            flasks = new Queue<Flask>();
        }

        /// <summary>
        /// Takes the queue item and enqueues it into the flasks queue
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
        /// Returns the queue item and dequeues it from the flasks queue
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
        /// Count of how many items in flasks queue
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
