using FlaskFactoryConsole.Utils;
using FlaskFactoryConsole.Model;
using FlaskFactoryConsole.View;
using System.Threading;

namespace FlaskFactoryConsole.Control
{
    /// <summary>
    /// This is our main Controller
    /// </summary>
    public class Factory
    {
        public static ConveyerBelt ProductionBelt = new ConveyerBelt();
        public static ConveyerBelt BeerBelt = new ConveyerBelt();
        public static ConveyerBelt SodaBelt = new ConveyerBelt();
        public static Producer Producer = new Producer(ProductionBelt);
        public static Splitter Splitter = new Splitter(ProductionBelt, BeerBelt, SodaBelt);
        public static EndConsumer BeerConsumer = new EndConsumer(BeerBelt, "BeerConsumer");
        public static EndConsumer SodaConsumer = new EndConsumer(SodaBelt, "SodaConsumer");

        /// <summary>
        /// This method Runs the Whole project with the threads
        /// </summary>
        public void Run()
        {
            Thread ProductionThread = new Thread(Producer.Run);

            ThreadPool.QueueUserWorkItem(Splitter.Pull);
            ThreadPool.QueueUserWorkItem(BeerConsumer.Pull);
            ThreadPool.QueueUserWorkItem(SodaConsumer.Pull);
            ThreadPool.QueueUserWorkItem(BeerConsumer.Print);
            ThreadPool.QueueUserWorkItem(SodaConsumer.Print);

            ThreadPool.QueueUserWorkItem(Splitter.Push);

            ProductionThread.Start();
            ProductionThread.Join();
        }
    }
}