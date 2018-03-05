using System;
using System.Collections.Generic;

namespace _07_Collections
{
    class Program
    {
        static void Main()
        {
            var evenNumbers = new HashSet<int>();
            var oddNumbers = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                evenNumbers.Add(i * 2);

                oddNumbers.Add(i * 2 + 1);
            }

            Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
            DisplaySet(evenNumbers);

            Console.Write("oddNumbers contains {0} elements: ", oddNumbers.Count);
            DisplaySet(oddNumbers);

            HashSet<int> numbers = new HashSet<int>(evenNumbers);
            Console.WriteLine("numbers UnionWith oddNumbers...");
            numbers.UnionWith(oddNumbers);

            Console.Write("numbers contains {0} elements: ", numbers.Count);
            DisplaySet(numbers);

        }

        private static void DisplaySet(HashSet<int> set)
        {
            Console.Write("{");
            foreach (int i in set)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }
    }
}
