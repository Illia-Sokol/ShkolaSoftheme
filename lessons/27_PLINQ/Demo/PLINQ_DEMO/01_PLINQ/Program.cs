using System;
using System.Linq;

namespace _01_PLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = Enumerable.Range(1, 10000).ToArray();

            // Opt in to PLINQ with AsParallel.
            var evenNums = from num in source.AsParallel()
                           where num % 2 == 0
                           select num;
            
            Console.WriteLine("{0} even numbers out of {1} total", evenNums.Count(), source.Count());

            Console.ReadKey();
        }
    }
}
