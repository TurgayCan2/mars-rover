using System.Collections.Generic;

namespace mars_rover
{
    public static class Direction
    {
        public static int NORTH = 1;
        public static int EAST = 2;
        public static int SOUTH = 3;
        public static int WEST = 4;

        private static Dictionary<int, char> DIRECTION_MAP = new Dictionary<int, char>()
        {
            {1, 'N'},
            {2, 'E'},
            {3, 'S'},
            {4, 'W'}
        };

        public static char getDirectionAsChar(int direction)
        {
            return DIRECTION_MAP[direction];
        }
    }
}