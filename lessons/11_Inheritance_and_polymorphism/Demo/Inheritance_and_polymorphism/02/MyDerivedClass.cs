using System;

namespace _02
{
    class MyDerivedClass : MyBaseClass
    {
        static MyDerivedClass()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("MyDerivedClass");
            Console.WriteLine("Static ctor");
            Console.ResetColor();
        }

        public MyDerivedClass()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("MyDerivedClass");
            Console.WriteLine("Default ctor");
            Console.ResetColor();
        }

        public MyDerivedClass(string message)
            : base(message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("MyDerivedClass");
            Console.WriteLine("Parameterized ctor");
            Console.ResetColor();
        }
    }
}