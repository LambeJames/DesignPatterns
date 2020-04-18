using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new CarBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetCar().GetParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetCar().GetParts());

            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom product:");
            builder.BuildChassis();
            builder.BuildEngine();
            Console.Write(builder.GetCar().GetParts());
        }
    }
}
