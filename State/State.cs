namespace State
{
    abstract class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            _context = context;
        }

        public abstract void GoFaster();

        public abstract void GoSlower();
    }
}
