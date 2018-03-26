using System;
using System.Threading;

namespace Timer_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int state = 0;
            TimerCallback callback = new TimerCallback(Count);
            Timer timer = new Timer(callback, state, 2000, 2000);

            Console.ReadLine();
        }
        
        public static void Count(object obj)
        {
            Console.WriteLine("{0}", (int)obj);
            Thread.Sleep(10000);
            Console.WriteLine("Finish");
        }
    }
}
