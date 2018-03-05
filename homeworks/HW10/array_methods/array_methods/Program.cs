using System;

namespace array_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var arr = new ArrayMethods(new int[] { 1, 2, 3, 4 });

            arr.PrintArrya();

            Console.WriteLine(arr.Contains(5));
            Console.WriteLine(arr.Contains(3));

            Console.WriteLine(arr.GetByIndex(2));

            arr.Add(5);
            arr.PrintArrya();

            Console.WriteLine();
        }
    }
}
