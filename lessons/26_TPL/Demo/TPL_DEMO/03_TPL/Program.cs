using System;
using System.Threading;
using System.Threading.Tasks;

namespace _03_TPL
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

            Console.WriteLine("SomeWork() finished, task id: {0}", Task.CurrentId);
        }

        static void Main()
        {
            Console.WriteLine("Main thread started");

            Task task1 = new Task(SomeWork);
            Task task2 = new Task(SomeWork);
            
            var tasks = new[] {task1, task2};

            task1.Start();
            task2.Start();

            //task1.Wait();
            //task2.Wait();

            //Task.WaitAll(tasks);

            Task.WaitAny(tasks);

            Console.WriteLine("Main thread finished");
            Console.ReadLine();
        }
    }
}
