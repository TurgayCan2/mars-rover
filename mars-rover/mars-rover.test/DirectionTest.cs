using NUnit.Framework;

namespace mars_rover.test
{
    [TestFixture]
    public class DirectionTest
    {
        [Test]
        public void shouldGetDirectionAsCharNorth()
        {
            char direction = Direction.getDirectionAsChar(1);

            Assert.AreEqual('N', direction);
        }

        [Test]
        public void shouldGetDirectionAsCharEast()
        {
            char direction = Direction.getDirectionAsChar(2);

            Assert.AreEqual('E', direction);
        }

        [Test]
        public void shouldGetDirectionAsCharSouth()
        {
            char direction = Direction.getDirectionAsChar(3);

            Assert.AreEqual('S', direction);
        }

        [Test]
        public void shouldGetDirectionAsCharWest()
        {
            char direction = Direction.getDirectionAsChar(4);

            Assert.AreEqual('W', direction);
        }

    }
}