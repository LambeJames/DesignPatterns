using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new Standing());
            context.Faster();
            context.Faster();
            context.Faster();
            context.Slower();
            context.Slower();
        }
    }
}
