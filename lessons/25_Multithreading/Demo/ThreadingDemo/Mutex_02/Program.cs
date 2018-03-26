using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace Mutex_02
{
    class Program
    {
        /*
        static void Main()
        {
            bool running;
            string guid = Marshal.GetTypeLibGuidForAssembly(Assembly.GetExecutingAssembly()).ToString();

            Mutex mutexObj = new Mutex(false, guid, out running);

            mutexObj.WaitOne();

            if (running)
            {
                Console.WriteLine("Application is working");
            }
            else
            {
                Console.WriteLine("Application already running.");
                Thread.Sleep(3000);
            }

            mutexObj.ReleaseMutex();

            Console.ReadLine();
        }
        */

        static void Main()
        {
            var mutex = GetApplicationMutex();

            try
            {
                mutex.WaitOne();
                for (var i = 0; i < 10; i++)
                {
                    Console.WriteLine("application is working...");
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
            }
            finally
            {
                mutex.ReleaseMutex();
            }

            Console.WriteLine("Work is done");
            Console.ReadLine();
        }

        private static Mutex GetApplicationMutex()
        {
            var guidMutexName = Marshal.GetTypeLibGuidForAssembly(Assembly.GetExecutingAssembly()).ToString();

            bool created;
            var mutex = new Mutex(false, guidMutexName, out created);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(!created ? "Application already running." : "Application is working");
            Console.ResetColor();

            return mutex;
        }
    }
}

