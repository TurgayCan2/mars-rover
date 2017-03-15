using mars_rover.rover;

namespace mars_rover.command.action
{
    public class RightCommandAction : ICommandAction
    {
        public void execute(Rover rover)
        {
            rover.turnRight();
        }
    }
}