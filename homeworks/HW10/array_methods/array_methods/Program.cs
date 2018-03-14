using System;

namespace array_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new ArrayMethods(new int[] { 1, 2, 3, 4 });

            arr.PrintArray();

            Console.WriteLine(arr.Contains(5));
            Console.WriteLine(arr.Contains(3));

            Console.WriteLine(arr.GetByIndex(2));

            arr.Add(10);
            arr.PrintArray();

            Console.WriteLine();
        }
    }
}
