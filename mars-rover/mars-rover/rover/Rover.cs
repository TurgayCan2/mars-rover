using System;

namespace mars_rover.rover
{
    public class Rover
    {
        public int CurrentX { get; set; } = 0;
        public int CurrentY { get; set; } = 0;
        public int CurrentDirection { get; set; } = Direction.NORTH;
        public Planet Destination { get; set; }

        private RoverEngine roverEngine = new RoverEngine();

        public Rover(int initX, int initY, int initDirection, Planet destination) : this(initX, initY, initDirection)
        {
            this.Destination = destination;
            validateBoundaries();
        }

        public Rover(int initX, int initY, int initDirection)
        {
            this.CurrentX = initX;
            this.CurrentY = initY;
            this.CurrentDirection = initDirection;
        }

        public string getCurrentPosition()
        {
            return $"{CurrentX} {CurrentY} {Direction.getDirectionAsChar(CurrentDirection)}";
        }

        public void receiveCommands(string commands)
        {
            foreach (char command in commands)
            {
                Console.WriteLine(this.getCurrentPosition());
                validateBoundaries();
                roverEngine.sendCommand(this, command);
            }
        }

        public void moveEast()
        {
            this.CurrentX++;
        }

        public void moveWest()
        {
            this.CurrentX--;
        }

        public void moveNorth()
        {
            this.CurrentY++;
        }

        public void moveSouth()
        {
            this.CurrentY--;
        }

        public void turnLeft()
        {
            this.CurrentDirection = isCurrentDirectionNorth() ? Direction.WEST : turnCounterClockWise();
        }

        private bool isCurrentDirectionNorth()
        {
            return this.CurrentDirection == Direction.NORTH;
        }

        public void turnRight()
        {
            this.CurrentDirection = isCurrentDirectionWest() ? Direction.NORTH :  turnClockWise();
        }

        private bool isCurrentDirectionWest()
        {
            return this.CurrentDirection == Direction.WEST;
        }

        private int turnClockWise()
        {
            return ++this.CurrentDirection;
        }

        private int turnCounterClockWise()
        {
            return --this.CurrentDirection;
        }
        private void validateBoundaries()
        {
            if (this.CurrentX > this.Destination.XBoundary || this.CurrentY > this.Destination.YBoundary)
            {
                throw new RoverArgumentException($"Boundaries not valid for init position values => {this.ToString()}");
            }
        }

        public override string ToString()
        {
            return $@"{nameof(CurrentX)}: {CurrentX}, {nameof(CurrentY)}: {CurrentY}, {nameof(CurrentDirection)}: {CurrentDirection}, {
                    nameof(Destination)
                }: {Destination.ToString()}";
        }
    }
}