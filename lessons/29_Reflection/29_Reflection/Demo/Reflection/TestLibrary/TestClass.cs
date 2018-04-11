using System;

namespace TestLibrary
{
    public class TestClass
    {
        private double _value1;
        private double _value2;

        public TestClass()
        {
            _value1 = _value2 = default(double);
        }

        public TestClass(double value1, double value2)
        {
            this._value1 = value1;
            this._value2 = value2;
        }

        public double Sum()
        {
            return _value1 + _value2;
        }

        public void Info()
        {
            Console.WriteLine(@"value1 = {0} value2 = {1}", _value1, _value2);
        }

        public void Set(int a, int b)
        {
            _value1 = (double)a;
            _value2 = (double)b;
        }

        public void Set(double a, double b)
        {
            _value1 = a;
            _value2 = b;
        }

        public override string ToString()
        {
            return "TestClass";
        }
    }
}
