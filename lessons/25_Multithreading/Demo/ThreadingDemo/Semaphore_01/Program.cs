using System;
using System.Threading;

namespace Semaphore_01
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i < 6; i++)
            {
                Reader reader = new Reader(i);
            }

            Console.ReadLine();
        }
    }

    class Reader
    {
        private static readonly Semaphore Semaphore = new Semaphore(3, 3);
        int _counter = 3;

        public Reader(int i)
        {
            var thread = new Thread(Read);
            thread.Name = "Reader " + i;
            thread.Start();
        }

        public void Read()
        {
            while (_counter > 0)
            {
                Semaphore.WaitOne();

                Console.WriteLine("{0} entered a library", Thread.CurrentThread.Name);

                Console.WriteLine("{0} reading", Thread.CurrentThread.Name);
                Thread.Sleep(1000);

                Console.WriteLine("{0} leaved library", Thread.CurrentThread.Name);

                Semaphore.Release();

                _counter--;
                Thread.Sleep(1000);
            }
        }
    }
}