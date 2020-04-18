using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Standing : State
    {
        public override void GoFaster()
        {
            _context.TransitionTo(new Walking());
        }

        public override void GoSlower()
        {
            Console.WriteLine("I'm already going nowhere");
        }
    }
}
