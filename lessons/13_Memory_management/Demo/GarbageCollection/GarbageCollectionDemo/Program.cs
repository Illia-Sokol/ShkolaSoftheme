using System;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main()
        {
            using (var calculator = new Calculator())
            {
                Console.WriteLine("{0} / {1} = {2}", 120, 0, calculator.Divide(120, 0));
            }

            Console.WriteLine("Program finishing");
        }
    }
}
