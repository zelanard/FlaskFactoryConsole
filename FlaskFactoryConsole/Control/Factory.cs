using FlaskFactoryConsole.Utils;
using FlaskFactoryConsole.Model;
using FlaskFactoryConsole.View;
using System.Threading;

namespace FlaskFactoryConsole.Control
{
    /// <summary>
    /// 
    /// </summary>
    public class Factory
    {
        public static ConveyerBelt ProductionBelt = new ConveyerBelt();
        public static ConveyerBelt BeerBelt = new ConveyerBelt();
        public static ConveyerBelt SodaBelt = new ConveyerBelt();
        public static Producer Producer = new Producer(ProductionBelt);
        public static Splitter Splitter = new Splitter(ProductionBelt, BeerBelt, SodaBelt);
        public static EndConsumer BeerConsumer = new EndConsumer(BeerBelt);
        public static EndConsumer SodaConsumer = new EndConsumer(SodaBelt);

        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            Thread ProductionThread = new Thread(Producer.Run);

            ThreadPool.QueueUserWorkItem(Splitter.Pull);
            ThreadPool.QueueUserWorkItem(BeerConsumer.Pull);
            ThreadPool.QueueUserWorkItem(SodaConsumer.Pull);
            ThreadPool.QueueUserWorkItem(state => BeerConsumer.Print());
            ThreadPool.QueueUserWorkItem(state => SodaConsumer.Print());

            ThreadPool.QueueUserWorkItem(state => Splitter.Push(FlaskTypes.BeerFlask));

            ProductionThread.Start();
            ProductionThread.Join();
        }
    }
}