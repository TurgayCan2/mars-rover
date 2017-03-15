using mars_rover.rover;

namespace mars_rover.command.action
{
    public class LeftCommandAction : ICommandAction
    {
        public void execute(Rover rover)
        {
            rover.turnLeft();
        }
    }
}