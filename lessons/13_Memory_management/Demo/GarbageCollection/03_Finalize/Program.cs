using System;
using System.Threading;

namespace _03_Finalize
{
    class Program
    {
        public static IntWrapper IntWrapperInstance { get; set; }

        static void Main(string[] args)
        {
            new Thread(() =>
            {
                Thread.Sleep(100);
                GC.Collect();
            }) { IsBackground = true }.Start();
            
            var wr = new WeakReference(new IntWrapper(10));
            
            Console.WriteLine("IsAlive = {0}", wr.IsAlive);
            
            ((IntWrapper)wr.Target).Run();
            
            Console.WriteLine("IsAlive = {0}", wr.IsAlive);
        }
    }
}
