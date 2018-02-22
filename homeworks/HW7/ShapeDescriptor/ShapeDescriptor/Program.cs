using System;

namespace ShapeDescriptor
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape1 = new ShapeDescriptor(1);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                shape1.A, shape1.B, shape1.C, shape1.D, shape1.E);

            var shape2 = new ShapeDescriptor(2, 3);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                shape2.A, shape2.B, shape2.C, shape2.D, shape2.E);

            var shape3 = new ShapeDescriptor(3, 4, 5);
            Console.WriteLine("{0} {1} {2} {3} {4}",
                shape3.A, shape3.B, shape3.C, shape3.D, shape3.E);

            var shape4 = new ShapeDescriptor(4, 5, 6, 7);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                shape4.A, shape4.B, shape4.C, shape4.D, shape4.E);
        }
    }
}
