namespace mars_rover
{
    public class Planet
    {
        private const string DEFAULT_NAME = "Mars";

        public string Name { get; set; } = DEFAULT_NAME;
        public int XBoundary { get; set; }
        public int YBoundary { get; set; }

        public Planet(int xBoundary, int yBoundary)
        {
            this.XBoundary = xBoundary;
            this.YBoundary = yBoundary;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(XBoundary)}: {XBoundary}, {nameof(YBoundary)}: {YBoundary}";
        }
    }
}