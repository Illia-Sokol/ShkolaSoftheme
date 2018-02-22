using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeDescriptor
{
    class ShapeDescriptor
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }
        public Point D { get; }
        public Point E { get; }

        public ShapeDescriptor(Point a)
        {
            A = a;
            ShapeType(A);
        }

        public ShapeDescriptor(Point a, Point b)
        {
            A = a;
            B = b;
            ShapeType(A, B);
        }

        public ShapeDescriptor(Point a, Point b, Point c) : this(a, b)
        {
            A = a;
            B = b;
            C = c;
            ShapeType(A, B, C);
        }

        public ShapeDescriptor(Point a, Point b, Point c, Point e) : this(null, b, c)
        {
            A = a;
            B = b;
            C = c;
            E = e;
            ShapeType(A, B, C, D);
        }

        public void ShapeType(Point a)
        {
            Console.WriteLine("The figure is the square");
        }

        public void ShapeType(Point a, Point b)
        {
            Console.WriteLine("The figure is the rectangle");
        }

        public void ShapeType(Point a, Point b, Point c)
        {
            Console.WriteLine("The figure is the triangle");
        }

        public void ShapeType(Point a, Point b, Point c, Point e)
        {
            Console.WriteLine("The figure is the romb");
        }
    }
}
