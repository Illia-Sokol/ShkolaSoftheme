using System;

namespace ShapeDescriptor
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape1 = new ShapeDescriptor(new Point(1, 2));

            var shape2 = new ShapeDescriptor(new Point(1, 2), new Point(3, 4));

            var shape3 = new ShapeDescriptor(new Point(1, 2), new Point(3, 4), new Point(5, 6));

            var shape4 = new ShapeDescriptor(new Point(1, 2), new Point(3, 4), new Point(5, 6), new Point(7, 8));
        }
    }
}
