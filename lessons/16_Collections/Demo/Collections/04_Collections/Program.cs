using System;
using System.Collections.Generic;

namespace _04_Collections
{
    //LIFO
    class Program
    {
        public static void Main()
        {
            Stack<string> numbers = new Stack<string>();
            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");
            numbers.Push("five");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nPopping '{0}'", numbers.Pop());
            Console.WriteLine("Peek at next item to destack: {0}", numbers.Peek());
            Console.WriteLine("Popping '{0}'", numbers.Pop());

            Console.WriteLine("\numbers.Contains(\"four\") = {0}", numbers.Contains("four"));

            Console.WriteLine("\numbers.Clear()");
            numbers.Clear();
            Console.WriteLine("\numbers.Count = {0}", numbers.Count);
        }
    }
}
