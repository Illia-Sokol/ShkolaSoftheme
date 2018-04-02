using System;
using System.Threading;

namespace _02_Async
{
    public delegate int DisplayHandler(int k);

    class Program
    {
        static void Main(string[] args)
        {
            DisplayHandler handler = new DisplayHandler(Display);

            IAsyncResult resultObj = handler.BeginInvoke(10, new AsyncCallback(AsyncCompleted), "Async invoke");

            Console.WriteLine("Main continue working");

            int res = handler.EndInvoke(resultObj);

            Console.WriteLine("Result: {0}", res);

            Console.ReadLine();
        }

        static int Display(int k)
        {
            Console.WriteLine("Display begin working...");

            int result = 0;
            for (int i = 1; i < 10; i++)
            {
                result += k * i;
            }
            Thread.Sleep(3000);
            Console.WriteLine("Display work finished...");
            return result;
        }

        static void AsyncCompleted(IAsyncResult resObj)
        {
            string mes = (string)resObj.AsyncState;
            Console.WriteLine(mes);
            Console.WriteLine("Async work completed");
        }
    }
}
