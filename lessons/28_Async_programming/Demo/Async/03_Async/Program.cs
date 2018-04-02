using System;
using System.Threading;
using System.Threading.Tasks;

namespace _03_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayResultAsync();
            
            Console.ReadLine();
        }

        static async void DisplayResultAsync()
        {
            int num = 5;

            int result = await FactorialAsync(num);

            Thread.Sleep(3000);
            Console.WriteLine("Factorial of number {0} equals: {1}", num, result);
        }

        static Task<int> FactorialAsync(int x)
        {
            int result = 1;

            var task = Task.Run(() =>
            {
                for (int i = 1; i <= x; i++)
                {
                    result *= i;
                }
                return result;
            });

            return task;
        }
    }
}
