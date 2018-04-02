using System;
using System.Threading.Tasks;

namespace _04_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayResultAsync().GetAwaiter();

            DisplayResultAsyncWhenAll().GetAwaiter();

            Console.ReadKey();
        }


        static async Task DisplayResultAsyncWhenAll()
        {
            int num1 = 5;
            int num2 = 6;
            Task<int> t1 = FactorialAsync(num1);
            Task<int> t2 = FactorialAsync(num2);
            Task<int> t3 = Task.Run(() =>
            {
                int res = 1;
                for (int i = 1; i <= 9; i++)
                {
                    res += i * i;
                }
                return res;
            });

            await Task.WhenAll(new[] { t1, t2, t3 });

            Console.WriteLine("Factorial of number {0} equals: {1}", num1, t1.Result);
            Console.WriteLine("Factorial of number {0} equals: {1}", num2, t2.Result);
            Console.WriteLine("Sum of numbers equals: {0}", t3.Result);
        }

        static async Task DisplayResultAsync()
        {
            int num = 5;
            int result = await FactorialAsync(num);
            Console.WriteLine("Factorial of number {0} equals: {1}", num, result);

            num = 6;
            result = FactorialAsync(num).GetAwaiter().GetResult();
            Console.WriteLine("Factorial of number {0} equals: {1}", num, result);

            result = await Task.Run(() =>
            {
                int res = 1;
                for (int i = 1; i <= 9; i++)
                {
                    res += i * i;
                }
                return res;
            });
            Console.WriteLine("Sum of numbers equals: {0}", result);
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
