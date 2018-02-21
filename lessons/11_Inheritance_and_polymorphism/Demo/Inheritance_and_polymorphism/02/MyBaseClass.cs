using System;

namespace _02
{
    class MyBaseClass
    {
        static MyBaseClass()
        {
            Console.WriteLine("MyBaseClass");
            Console.WriteLine("Static ctor");
        }

        public MyBaseClass()
        {
            Console.WriteLine("MyBaseClass");
            Console.WriteLine("Default ctor");
        }

        public MyBaseClass(string message)
        {
            Console.WriteLine("MyBaseClass");
            Console.WriteLine("Parameterized ctor");
            Console.WriteLine(message);
        }
    }
}