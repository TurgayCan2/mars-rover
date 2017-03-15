using System;
using mars_rover.command;

namespace mars_rover.rover
{
    public class RoverEngine
    {
        public void sendCommand(Rover rover, char command)
        {
            if (!isCommandValid(command))
            {
                throw new CommandNotFoundException($"Command : {command} is not valid!");
            }

            CommandMap.COMMAND_ACTIONS[command].execute(rover);
        }

        public bool isCommandValid(char command)
        {
            return CommandMap.getCommands().Exists(each => each == command);
        }
    }
}