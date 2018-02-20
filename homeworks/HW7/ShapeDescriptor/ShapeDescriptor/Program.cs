using System;

namespace ShapeDescriptor
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape1 = new ShapeDescriptor(2);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                shape1._a, shape1._b, shape1._c, shape1._d, shape1._e);

            var shape2 = new ShapeDescriptor(1, 2, 3);
            Console.WriteLine("{0} {1} {2} {3} {4}",
                shape2._a, shape2._b, shape2._c, shape2._d, shape2._e);
        }
    }
}
