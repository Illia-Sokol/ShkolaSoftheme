using System;
using System.Threading;
using System.Threading.Tasks;

namespace _04_TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");

            Task task1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("SomeWork() running, task id: {0}", Task.CurrentId);

                for (int count = 0; count < 10; count++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("SomeWork() with task id: {0} Counter: {1}", Task.CurrentId, count);
                }

                Console.WriteLine("SomeWork() finished, task id: {0}", Task.CurrentId);
            });

            task1.Wait();

            Console.WriteLine("Main thread finished");
            Console.ReadLine();
        }
    }
}
