using System;
using System.Threading;

namespace AutoResetEvent_01
{
    class Program
    {
        static void Main()
        {
            var autoResetEvent = new AutoResetEvent(false);

            var workerThread = new Thread(() =>
            {
                while (true)
                {
                    autoResetEvent.WaitOne();
                    Console.WriteLine("go");
                }
            });

            workerThread.Start();

            while (true)
            {
                Console.WriteLine("pulse");
                autoResetEvent.Set();
                Thread.Sleep(1000);
            }
        }
    }
}