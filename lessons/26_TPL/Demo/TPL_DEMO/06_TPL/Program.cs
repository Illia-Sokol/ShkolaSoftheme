using System;
using System.Threading;
using System.Threading.Tasks;

namespace _06_TPL
{
    class Program
    {
        static void SomeWork()
        {
            Console.WriteLine("SomeWork started");
            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("--> SomeWork Count=" + count);
            }
            Console.WriteLine("SomeWork finished");
        }

        static void SomeWork2()
        {
            Console.WriteLine("SomeWork2 started");
            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("--> SomeWork2 Count=" + count);
            }

            Console.WriteLine("SomeWork2 finished");
        }

        static void Main()
        {
            Console.WriteLine("Main thread started");

            // Run and wait several parallel task
            Parallel.Invoke(SomeWork, SomeWork2);

            //Task.WaitAll(Task.Factory.StartNew(SomeWork), Task.Factory.StartNew(SomeWork2));

            Console.WriteLine("Main thread finished");
            Console.ReadLine();
        }
    }
}
