using NUnit.Framework;

namespace mars_rover.test
{
    [TestFixture]
    public class PlanetTest
    {
        [Test]
        public void shouldInitPlanetMarsBoundariesAs5x5()
        {
            Planet planet = new Planet(5,5);

            Assert.AreEqual(5, planet.XBoundary);
            Assert.AreEqual(5, planet.YBoundary);
            Assert.AreEqual("Mars", planet.Name);
        }
    }
}