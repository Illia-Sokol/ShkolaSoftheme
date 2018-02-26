using System;
using System.Threading;

namespace _02_Finalize
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                Thread.Sleep(100);
                GC.Collect();
            }) { IsBackground = true }.Start();

            new IntWrapper(10).Run();
        }
    }
}
