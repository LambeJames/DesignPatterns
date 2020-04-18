using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Context
    {
        private State _state = null;

        public Context(State state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"I'm now {state.GetType().Name}.");
            _state = state;
            _state.SetContext(this);
        }

        public void Faster()
        {
            _state.GoFaster();
        }

        public void Slower()
        {
            _state.GoSlower();
        }
    }
}
