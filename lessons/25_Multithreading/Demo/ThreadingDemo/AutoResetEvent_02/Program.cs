using System;
using System.Globalization;
using System.Threading;

namespace AutoResetEvent_02
{
    class Program
    {
        static readonly AutoResetEvent WaitHandler = new AutoResetEvent(true);

        static void Main()
        {
            var threadsCount = 100;

            for (var i = 0; i < threadsCount; i++)
            {
                var myThread = new Thread(Count)
                {
                    Name = string.Format(CultureInfo.InvariantCulture, "Thread {0}", i)
                };

                myThread.Start();
            }

            for (var i = 0; i < threadsCount; i++)
            {
                Console.ReadLine();
                WaitHandler.Set();
            }

            Console.ReadLine();
        }

        public static void Count()
        {
            WaitHandler.WaitOne();
            Console.WriteLine("CurrentThread.Name: {0}", Thread.CurrentThread.Name);
        }
    }
}
