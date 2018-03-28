using System;
using System.Threading;
using System.Threading.Tasks;

namespace _02_TPL
{
    class Program
    {
        static void SomeWork()
        {
            Console.WriteLine("SomeWork() running, task id: {0}", Task.CurrentId);

            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("SomeWork() with task id: {0} Counter: {1}", Task.CurrentId, count);
            }
        }

        static void Main()
        {
            Console.WriteLine("Main thread started");

            Task task1 = new Task(SomeWork);
            Task task2 = new Task(SomeWork);

            task1.Start();
            task2.Start();

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
