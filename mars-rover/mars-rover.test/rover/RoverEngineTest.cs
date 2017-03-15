using mars_rover.rover;
using NUnit.Framework;

namespace mars_rover.test
{
    [TestFixture]
    public class RoverEngineTest
    {

        [Test]
        public void shouldSendMCommand()
        {
            RoverEngine roverEngine = new RoverEngine();
            Planet planet = new Planet(5, 5);
            Rover rover = new Rover(0, 0, Direction.NORTH, planet);
            roverEngine.sendCommand(rover,'M');

            Assert.AreEqual("0 1 N", rover.getCurrentPosition());
        }

        [Test]
        public void shouldReturnFalseIfCommandsNotValid()
        {
            RoverEngine roverEngine = new RoverEngine();

            bool isValid = roverEngine.isCommandValid('P');

            Assert.False(isValid);
        }

        [Test]
        public void shouldReturnTrueIfCommandsValidForMCommand()
        {
            RoverEngine roverEngine = new RoverEngine();

            bool isValid = roverEngine.isCommandValid('M');

            Assert.True(isValid);
        }

        [Test]
        public void shouldReturnTrueIfCommandsValidForLCommand()
        {
            RoverEngine roverEngine = new RoverEngine();

            bool isValid = roverEngine.isCommandValid('L');

            Assert.True(isValid);
        }

        [Test]
        public void shouldReturnTrueIfCommandsValidForRCommand()
        {
            RoverEngine roverEngine = new RoverEngine();

            bool isValid = roverEngine.isCommandValid('R');

            Assert.True(isValid);
        }
    }
}