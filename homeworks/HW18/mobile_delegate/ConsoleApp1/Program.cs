using System;

namespace Mobile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var account = new MobileAccount(12345);
        }

        private static void ShowMessage(object sender, CallInfo e)
        {
            Console.WriteLine("Sum of the transaction: {0}", e.Sender);
        }
    }
}
