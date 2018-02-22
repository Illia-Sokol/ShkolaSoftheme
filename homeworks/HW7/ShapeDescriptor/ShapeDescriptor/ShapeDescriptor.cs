using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeDescriptor
{
    class ShapeDescriptor
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int E { get; set; }

        public ShapeDescriptor(int a)
        {
            A = a;
            ShapeType(A);
        }

        public ShapeDescriptor(int a, int b)
        {
            A = a;
            B = b;
            ShapeType(A, B);
        }

        public ShapeDescriptor(int a, int b, int c) : this(a, 0)
        {
            A = a;
            B = b;
            C = c;
            ShapeType(A, B, C);
        }

        public ShapeDescriptor(int a, int b, int c, int e) : this(1, b, c)
        {
            A = a;
            B = b;
            C = c;
            E = e;
            ShapeType(A, B, C, D);
        }

        public void ShapeType(int a)
        {
            Console.WriteLine("The figure is the square");
        }

        public void ShapeType(int a, int b)
        {
            Console.WriteLine("The figure is the rectangle");
        }

        public void ShapeType(int a, int b, int c)
        {
            Console.WriteLine("The figure is the triangle");
        }

        public void ShapeType(int a, int b, int c, int e)
        {
            Console.WriteLine("The figure is the romb");
        }
    }
}
