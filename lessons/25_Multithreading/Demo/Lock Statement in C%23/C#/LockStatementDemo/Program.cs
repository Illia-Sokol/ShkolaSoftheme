using System;
using System.Collections.Generic;
using System.Threading;

namespace LockStatementDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass oMyClass = new MyClass();
            List<Thread> threads = new List<Thread>();

            for (var i = 0; i < 5; i++)
            {
                var thread = new Thread(new ThreadStart(() =>
                {
                    oMyClass.MethodWithoutLock();
                    oMyClass.MethodWithLock();
                }));
                threads.Add(thread);
            }

            foreach (Thread t in threads)
            {
                t.Start();
            }

            Console.WriteLine(DateTime.Now);
        }
    }

    public class MyClass
    {
        private readonly object _lockObject = new object();

        public void MethodWithoutLock()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Without Lock " + DateTime.Now);
        }

        public void MethodWithLock()
        {
            lock (_lockObject)
            {
                Thread.Sleep(5000);
                Console.WriteLine("With Lock " + DateTime.Now);
            }
        }
    }
}
