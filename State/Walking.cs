namespace State
{
    class Walking : State
    {
        public override void GoFaster()
        {
            _context.TransitionTo(new Running());
        }

        public override void GoSlower()
        {
            _context.TransitionTo(new Standing());
        }
    }
}
