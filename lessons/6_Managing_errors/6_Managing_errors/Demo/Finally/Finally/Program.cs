using System;
using System.Threading;

namespace Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    var tempObject = new ExceptionThrowableFinalizer();
                    //var tempObject = new ExceptionThrowableCtor();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            try
            {
                GC.Collect();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Thread.Sleep(TimeSpan.FromSeconds(1));

            Console.WriteLine("Program finished");
        }
    }
}
