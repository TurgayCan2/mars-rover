using System.Collections.Generic;
using System.Linq;
using mars_rover.command.action;

namespace mars_rover.command
{
    public static class CommandMap
    {
        private static char LEFT = 'L';
        private static char RIGHT = 'R';
        private static char MOVE = 'M';

        public static Dictionary<char, ICommandAction> COMMAND_ACTIONS = new Dictionary<char, ICommandAction>
        {
            {LEFT, new LeftCommandAction()},
            {RIGHT, new RightCommandAction()},
            {MOVE, new MoveCommandAction()}
        };

        public static List<char> getCommands()
        {
            return COMMAND_ACTIONS.Keys.ToList();
        }
    }
}