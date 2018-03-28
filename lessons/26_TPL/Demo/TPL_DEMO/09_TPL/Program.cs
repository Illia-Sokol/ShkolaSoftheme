using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _09_TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            ParallelLoopResult result = Parallel.ForEach(new List<int> { 1, 3, 5, 8, 13 }, Factorial);
            Console.WriteLine("Work is completed: {0}", result.IsCompleted);
            
            Console.ReadLine();
        }

        static void Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }

            Console.WriteLine("Task running, id: {0}", Task.CurrentId);
            Console.WriteLine("factorial of number {0} equals {1}", x, result);
            Thread.Sleep(3000);
        }
    }
}
