using System;
using System.Threading;
using System.Threading.Tasks;

namespace _05_TPL
{
    class Program
    {
        static void SomeWork(Object ct)
        {
            CancellationToken token = (CancellationToken)ct;
            token.ThrowIfCancellationRequested();

            Console.WriteLine("SomeWork() running, task id: {0}", Task.CurrentId);

            for (int count = 0; count < 10; count++)
            {
                if (!token.IsCancellationRequested)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("SomeWork() with task id: {0} Counter: {1}", Task.CurrentId, count);
                }
                else
                {
                    Console.WriteLine("Cancell requested");
                    break;
                }
            }

            Console.WriteLine("SomeWork() finished, task id: {0}", Task.CurrentId);
        }

        static void Main()
        {
            Console.WriteLine("Main thread started");

            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationTokenSource cts1 = new CancellationTokenSource();
            cts1.Cancel();

            Task task = Task.Factory.StartNew(SomeWork, cts.Token, cts.Token);

            Thread.Sleep(2000);
            try
            {
                cts.Cancel();
                task.Wait();
            }
            catch (OperationCanceledException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Task wait was canceled");
                Console.ResetColor();
            }

            Console.WriteLine("Main thread finished");
            Console.ReadLine();
        }
    }
}