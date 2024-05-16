using System.Collections.Generic;
using FlaskFactoryConsole.Model.Flasks;

namespace FlaskFactoryConsole.Utils
{
	/// <summary>
	/// The ConveyerBelt class represents a conveyer belt in a factory production line.
	/// It uses a queue to simulate the line of flasks moving along the belt.
	/// </summary>
	public class ConveyerBelt
    {
        public const int MAX_SIZE = 99;
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
