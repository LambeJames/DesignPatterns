using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Observer
{
    public class OrderService : ISubject
    {
        public bool OrderProcessed { get; set; }

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Detached an observer.");
        }

        public void Notify()
        {
            Console.WriteLine("Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void ProcessOrder()
        {
            Console.WriteLine("\n I'm processing the order.");
            this.OrderProcessed = true;

            Thread.Sleep(15);

            Console.WriteLine("The order has been processed");
            this.Notify();
        }
    }
}
