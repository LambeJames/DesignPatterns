using System;

namespace Observer
{
    public class EmailService : IObserver
    {
        public void Update(ISubject subject)
        {
            Send();
        }

        private void Send()
        {
            Console.WriteLine("Confirmation email sent to customer");
        }
    }
}
