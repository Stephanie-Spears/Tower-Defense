namespace Tower_Defense
{
    class Tower_DefenseException : System.Exception
    {
        public Tower_DefenseException()
        {
        }

        public Tower_DefenseException(string message) : base(message)
        {
        }
    }

    class OutOfBoundsException : Tower_DefenseException
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}