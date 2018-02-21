using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            var base1 = new MyBaseClass();

            Console.WriteLine("------------------\n");

            var base2 = new MyBaseClass("Hi to all");

            Console.WriteLine("------------------\n");

            var derived1 = new MyDerivedClass();

            Console.WriteLine("------------------\n");

            var derived2 = new MyDerivedClass("Hello world");

            Console.WriteLine("n------------------\n");

            Console.ReadKey();
        }
    }
}
