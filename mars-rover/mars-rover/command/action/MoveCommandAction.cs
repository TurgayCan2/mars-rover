using mars_rover.rover;

namespace mars_rover.command.action
{
    public class MoveCommandAction : ICommandAction
    {
        public void execute(Rover rover)
        {
            if (rover.CurrentDirection == Direction.NORTH)
            {
                rover.moveNorth();
                return;
            }
            if (rover.CurrentDirection == Direction.EAST)
            {
                rover.moveEast();
                return;
            }
            if (rover.CurrentDirection == Direction.SOUTH)
            {
                rover.moveSouth();
                return;
            }
            if (rover.CurrentDirection == Direction.WEST)
            {
                rover.moveWest();
            }
        }
    }
}