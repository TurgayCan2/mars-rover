using System;

namespace mars_rover.command
{
    public class CommandNotFoundException : Exception
    {
        public CommandNotFoundException()
        {
        }

        public CommandNotFoundException(string message) : base(message)
        {
        }

        public CommandNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}