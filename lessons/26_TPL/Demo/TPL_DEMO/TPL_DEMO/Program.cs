using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_DEMO
{
    class Program
    {
        static void SomeWork()
        {
            Console.WriteLine("SomeWork() running");

            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("Counter: {0}", count);
            }
        }

        static void Main()
        {
            Console.WriteLine("Main thread started");

            Task task = new Task(SomeWork);
            task.Start();

            for (int i = 0; i < 60; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            Console.WriteLine("Main thread finished");
            Console.ReadLine();
        }
    }
}
