using System;

namespace mars_rover.rover
{
    public class RoverArgumentException : Exception
    {
        public RoverArgumentException()
        {
        }

        public RoverArgumentException(string message) : base(message)
        {
        }

        public RoverArgumentException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}