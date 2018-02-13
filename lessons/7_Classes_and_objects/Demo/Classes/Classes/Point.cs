using System;

namespace Classes
{
    class Point
    {
        private readonly int _x = 0;
        private readonly int _y;
        private static int _objectCount = 0;

        public Point()
        {
            _x = -1;
            _y = -1;
            _objectCount++;
        }

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
            _objectCount++;
        }

        public double DistanceTo(Point otherPoint)
        {
            var xDiff = _x - otherPoint._x;
            var yDiff = _y - otherPoint._y;
            var distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }

        public static int ObjectCount()
        {
            return _objectCount;
        }
    }
}
