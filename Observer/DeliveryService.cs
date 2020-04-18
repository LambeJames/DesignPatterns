using System;

namespace Observer
{
    public class DeliveryService : IObserver
    {
        public void Update(ISubject subject)
        {
            Deliver();
        }

        private void Deliver()
        {
            Console.WriteLine("Order out for delivery.");
        }
    }
}
