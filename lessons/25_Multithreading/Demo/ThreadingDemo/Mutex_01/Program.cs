using System;
using System.Threading;

namespace Mutex_01
{
    class Program
    {
        static readonly Mutex MutexObj = new Mutex();
        private static int _counter = 0;

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = "Thread " + i;
                myThread.Start();
            }

            Console.ReadLine();
        }

        public static void Count()
        {
            MutexObj.WaitOne();
            _counter = 1;
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, _counter);
                _counter++;
                Thread.Sleep(100);
            }
            MutexObj.ReleaseMutex();
        }
    }
}
