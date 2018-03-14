using System;

namespace Events_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Account account = new Account(200, 6);
            account.Added += ShowMessage;
            account.Withdrowed += ShowMessage;

            account.Withdraw(100);
            account.Withdrowed -= ShowMessage;

            account.Withdraw(50);
            account.Put(150);

            Console.ReadLine();
        }

        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    } 
}
