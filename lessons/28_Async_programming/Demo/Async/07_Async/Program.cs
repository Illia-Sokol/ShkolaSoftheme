using System;
using System.Threading;
using System.Threading.Tasks;

namespace _07_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayResultAsync(6);

            Console.Read();
        }

        static async void DisplayResultAsync(int num)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            try
            {
                Task t1 = FactorialAsync(num, cts.Token);
                Task t2 = Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    cts.Cancel();
                });
                
                await Task.WhenAll(t1, t2);
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cts.Dispose();
            }
        }

        static Task FactorialAsync(int x, CancellationToken token)
        {
            return Task.Run(() =>
            {
                int result = 1;
                for (int i = 1; i <= x; i++)
                {
                    token.ThrowIfCancellationRequested();
                    result *= i;
                    Console.WriteLine("Factorial of number {0} equals: {1}", i, result);
                    Thread.Sleep(1000);
                }
            }, token);
        }
    }
}
