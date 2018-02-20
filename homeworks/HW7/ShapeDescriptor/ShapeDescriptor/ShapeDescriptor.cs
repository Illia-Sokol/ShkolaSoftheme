using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeDescriptor
{
    class ShapeDescriptor
    {
        public int _a { get; set; }
        public int _b { get; set; }
        public int _c { get; set; }
        public int _d { get; set; }
        public int _e { get; set; }

        public ShapeDescriptor(int a)
        {
            _a = _b = _c = _d = _e = a;
        }

        public ShapeDescriptor(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public ShapeDescriptor(int a, int b, int c, int e) : this(a, b, 0)
        {
            _a = a;
            _b = b;
            _c = c;
            _e = e;
        }

        public void ShapeType()
        {

        }
    }
}
