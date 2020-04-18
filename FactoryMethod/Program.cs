using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of floors between 1 and 12 to build a property and press enter");

            var floors = Console.ReadLine();
            var property = PropertyFactory.Build(Convert.ToInt32(floors));
            Console.WriteLine($" You built a {property.GetType().Name}");
            Console.Read();
        }
    }
}
