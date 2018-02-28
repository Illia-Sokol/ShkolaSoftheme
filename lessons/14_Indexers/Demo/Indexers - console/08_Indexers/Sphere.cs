using _04_Indexers;

namespace _08_Indexers
{
    class Sphere : ICoordinatesIndexer
    {
        private readonly int _x;
        private readonly int _y;
        private readonly int _z;
        private readonly int _radius;

        public Sphere(int x, int y, int z, int radius)
        {
            _x = x;
            _y = y;
            _z = z;
            _radius = radius;
        }

        public bool this[Point point]
        {
            get { return this[point.X, point.Y, point.Z]; }
            set { this[point.X, point.Y, point.Z] = value; }
        }

        public bool this[int x, int y, int z]
        {
            get
            {
                if (x < _x - _radius || x > _x + _radius)
                {
                    return false;
                }

                if (y < _y - _radius || y > _y + _radius)
                {
                    return false;
                }

                if (z < _z - _radius || z > _z + _radius)
                {
                    return false;
                }

                return true;
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
