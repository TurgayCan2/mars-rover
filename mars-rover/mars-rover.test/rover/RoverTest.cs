using mars_rover.command;
using mars_rover.rover;
using NUnit.Framework;

namespace mars_rover.test.rover
{
    [TestFixture]
    public class RoverTest
    {
        [Test]
        public void shouldGetCurrentPositionForInitDefaultValuesAs0x0xN()
        {
            Planet planet = new Planet(5, 5);
            Rover rover = new Rover(0, 0, Direction.NORTH, planet);

            string currentPosition = rover.getCurrentPosition();

            Assert.AreEqual("0 0 N", currentPosition);
        }

        [Test]
        public void shouldThrowPlanetExceptionWhenInitValues()
        {
            Planet planet = new Planet(5, 5);
            Assert.Throws<RoverArgumentException>(() => new Rover(6, 0, Direction.NORTH, planet));
        }

        [Test]
        public void shouldGetCurrentPositionForInitDefaultValuesAs10x10xNForMarsAs5x5()
        {
            Planet planet = new Planet(5, 5);
            Rover rover = new Rover(0, 0, Direction.NORTH, planet);

            string currentPosition = rover.getCurrentPosition();

            Assert.AreEqual("0 0 N", currentPosition);
        }

        [Test]
        public void shouldBeWestDirectionOfHeadIfTurnLeftForCurrentPositionOfHeadIsNorth()
        {
            Planet planet = new Planet(5, 5);
            Rover rover = new Rover(0, 0, Direction.NORTH, planet);

            rover.turnLeft();

            Assert.AreEqual(Direction.WEST, rover.CurrentDirection);
        }

        [Test]
        public void shouldBeNorthDirectionOfHeadIfTurnRightForCurrentPositionOfHeadIsWest()
        {
            Planet planet = new Planet(5, 5);
            Rover rover = new Rover(0, 0, Direction.WEST, planet);

            rover.turnRight();

            Assert.AreEqual(Direction.NORTH, rover.CurrentDirection);
        }

        [Test]
        public void shouldGetLastPositionThatIsGiveInputAsMars5x5AndRover1x2xNInitValues()
        {
            Planet planet = new Planet(5, 5);
            Rover rover = new Rover(1, 2, Direction.NORTH, planet);
            rover.receiveCommands("LMLMLMLMM");
            string currentPosition = rover.getCurrentPosition();

            Assert.AreEqual("1 3 N", currentPosition);
        }

        [Test]
        public void shouldGetLastPositionThatIsGiveInputAsMars5x5AndRover3x3xEInitValues()
        {
            Planet planet = new Planet(5, 5);
            Rover rover = new Rover(3, 3, Direction.EAST, planet);

            rover.receiveCommands("MMRMMRMRRM");

            string currentPosition = rover.getCurrentPosition();

            Assert.AreEqual("5 1 E", currentPosition);
        }

        [Test]
        public void shouldGetLastPositionThatIsGiveInputAsMars5x5AndRover0x0xNInitValues()
        {
            Planet planet = new Planet(5, 5);
            Rover rover = new Rover(0, 0, Direction.NORTH, planet);

            rover.receiveCommands("MMRMMRMRRM");

            string currentPosition = rover.getCurrentPosition();

            Assert.AreEqual("2 2 N", currentPosition);
        }

        [Test]
        public void shouldThrowCommandNotFoundExceptionAndGetLastPositionThatIsGiveInputAsMars5x5AndRover0x0xNInitValues()
        {
            Planet planet = new Planet(5, 5);
            Rover rover = new Rover(0, 0, Direction.NORTH, planet);

            Assert.Throws<CommandNotFoundException>(() => rover.receiveCommands("MMRMMRMRRMRPRMRM"));

            string currentPosition = rover.getCurrentPosition();

            Assert.AreEqual("2 2 E", currentPosition);
        }
    }
}