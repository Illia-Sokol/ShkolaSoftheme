using System;
using System.Threading;

namespace Async
{
    class Program
    {
        public delegate int DisplayHandler();
        
        static void Main(string[] args)
        {
            DisplayHandler handler = new DisplayHandler(Display);
            IAsyncResult resultObj = handler.BeginInvoke(null, null);

            Console.WriteLine("Main is working");
            
            int result = handler.EndInvoke(resultObj);
            Console.WriteLine("Result {0}", result);

            Console.ReadLine();
        }

        static int Display()
        {
            Console.WriteLine("Display begin working...");

            int result = 0;
            for (int i = 1; i < 10; i++)
            {
                result += i * i;
            }

            Thread.Sleep(3000);
            Console.WriteLine("Display work finished...");
            return result;
        }
    }
}
