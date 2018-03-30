using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;

namespace _02_PLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var concurrentBag = new ConcurrentBag<int>();

            var nums = Enumerable.Range(10, 10000);
            var query = from num in nums.AsParallel()
                        where num % 10 == 0
                        select num;

            // Process the results as each thread completes
            // and add them to a System.Collections.Concurrent.ConcurrentBag(Of Int)
            // which can safely accept concurrent add operations
            query.ForAll(e => concurrentBag.Add(Compute(e)));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("All operations are finished");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Results:");
            foreach (var item in concurrentBag)
            {
                Console.Write(" {0} |", item);
            }
        }

        private static int Compute(int i)
        {
            Console.WriteLine("Working with number: {0}", i);
            Thread.Sleep(TimeSpan.FromMilliseconds(50));
            var result = new Random().Next(99999);
            return result;
        }
    }
}
