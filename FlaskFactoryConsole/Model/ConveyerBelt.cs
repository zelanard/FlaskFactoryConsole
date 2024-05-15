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
		/// Constructor for the ConveyerBelt class. Initializes an empty queue of flasks.
		/// </summary>
		public ConveyerBelt()
        {
            flasks = new Queue<Flask>();
        }

		/// <summary>
		/// Adds a flask to the end of the conveyer belt, if there is room.
		/// </summary>
		/// <param name="item">The flask to be added to the conveyer belt.</param>
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
		/// Removes and returns the flask at the front of the conveyer belt.
		/// </summary>
		/// <returns>The flask at the front of the conveyer belt, or null if the belt is empty.</returns>
		public Flask Dequeue()
        {
            lock (lockObject)
            {
                return flasks.Count > 0 ? flasks.Dequeue() : null;
            }
        }

		/// <summary>
		/// Gets the number of flasks currently on the conveyer belt.
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
