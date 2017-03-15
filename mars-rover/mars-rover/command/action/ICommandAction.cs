using mars_rover.rover;

namespace mars_rover.command.action
{
    public interface ICommandAction
    {
        void execute(Rover rover);
    }
}