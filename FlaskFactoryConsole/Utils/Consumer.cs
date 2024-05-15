using FlaskFactoryConsole.Model;
using FlaskFactoryConsole.Model.Flasks;

namespace FlaskFactoryConsole.Utils
{
    /// <summary>
    /// Abstract class representing a consumer that processes flasks from a buffer.
    /// </summary>
    public abstract class Consumer
    {
        /// <summary>
        /// Holds the current flask being processed.
        /// </summary>
        protected Flask CurrentFlask;

        /// <summary>
        /// Buffer from which the flasks are consumed.
        /// </summary>
        protected Buffer Buffer { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Consumer class with the specified buffer.
        /// </summary>
        /// <param name="buffer">The buffer from which flasks are to be consumed.</param>
        public Consumer(Buffer buffer)
        {
            Buffer = buffer;
        }

        /// <summary>
        /// Consumes a flask from the buffer based on the specified flask ID.
        /// </summary>
        /// <param name="id">The ID of the flask to be consumed.</param>
        public void Pull()
        {
            if (CurrentFlask == null && Buffer.flasks.Count > 0)
            {
                CurrentFlask = Buffer.flasks.Dequeue();
            }
        }
    }
}