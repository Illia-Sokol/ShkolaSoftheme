using System;
using System.Threading;
using System.Threading.Tasks;

namespace _05_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayResultAsync(5).GetAwaiter();
            Console.ReadLine();
        }

        static async Task DisplayResultAsync(int num)
        {
            try
            {
                int result = await FactorialAsync(num);
                Thread.Sleep(3000);
                Console.WriteLine("Factorial of number {0} equals: {1}", num, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static async Task<int> FactorialAsync(int x)
        {
            int result = 1;
            if (x < 1)
            {
                throw new ArgumentException(string.Format("Number should be bigger than 0. Actual number is: {0}", x));
            }

            return await Task.Run(() =>
            {
                for (int i = 1; i <= x; i++)
                {
                    result *= i;
                }
                return result;
            });
        }
    }
}
