using System;
using System.Threading;
using System.Threading.Tasks;

namespace _06_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayResultAsync(0).GetAwaiter();
            Console.Read();
        }

        static async Task DisplayResultAsync(int num)
        {
            Task<int> fact = FactorialAsync(num);

            try
            {
                int result = 1;
                if (num < 1)
                {
                    throw new Exception(string.Format("Number should be bigger than 0. Actual number is: {0}", num));
                }

                result = await Task.Run(() =>
                {
                    for (int i = 1; i <= num; i++)
                    {
                        result *= i;
                    }
                    return result;
                });
                Console.WriteLine("Factorial of number {0} equals: {1}", num, result);
            }
            catch (Exception ex)
            {
                await Log(ex);
            }
            finally
            {
                await Task.Run(() => Console.WriteLine("await in finally"));
            }
        }

        static async Task Log(Exception ex)
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(ex);
                Console.ResetColor();
            });
        }

        static Task<int> FactorialAsync(int x)
        {
            int result = 1;

            return Task.Run(() =>
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
