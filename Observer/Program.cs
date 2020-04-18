using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderService = new OrderService();
            var deliveryService = new DeliveryService();
            orderService.Attach(deliveryService);

            var emailService = new EmailService();
            orderService.Attach(emailService);

            orderService.ProcessOrder();

            orderService.Detach(emailService);

            orderService.ProcessOrder();

            Console.Read();
        }
    }
}
