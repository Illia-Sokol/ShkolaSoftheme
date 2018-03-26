using System;
using System.Collections.Generic;
using System.Threading;

namespace Monitor_01
{
    class Program
    {
        private static readonly object LockObject = new object();
        private static readonly Queue<int> Numbers = new Queue<int>();
        private static readonly int[] NumbersToProcess = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        static void Main()
        {
            var writeThread = new Thread(Write);
            var writeThread2 = new Thread(Write);
            var readThread = new Thread(Read);

            writeThread.Start();
            readThread.Start();
            writeThread2.Start();


            writeThread.Join();
            writeThread2.Join();
            readThread.Join();
        }

        public static void Read()
        {
            while (true)
            {
                lock (LockObject)
                {
                    while (Numbers.Count == 0)
                    {
                        Monitor.Wait(LockObject);
                    }

                    Console.WriteLine(Numbers.Dequeue());
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
            }
        }

        public static void Write()
        {
            for (var i = 0; i < NumbersToProcess.Length; i++)
            {
                lock (LockObject)
                {
                    Numbers.Enqueue(NumbersToProcess[i]);
                    Monitor.Pulse(LockObject);
                }
            }

            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
    }
}
