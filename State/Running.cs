using System;

namespace State
{
    class Running : State
    {
        public override void GoFaster()
        {
            Console.WriteLine("This is as fast as I go");
        }

        public override void GoSlower()
        {
            _context.TransitionTo(new Walking());
        }
    }
}
