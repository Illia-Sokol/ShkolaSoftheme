using System;

namespace Events
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

            /*
            var input = "Hello world";

            Print("Hello Nick", (message) =>
                {
                    if (input.Equals(message))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    return message + "!!!";
                });
                */

            Console.ReadLine();
        }

        private static void ShowMessage(object sender, AccountEventArgs e)
        {
            var account = sender as Account;
            if (account != null)
            {
                var accountSum = account.CurrentSum;
                Console.WriteLine(accountSum);
            }

            Console.WriteLine("Sum of the transaction: {0}", e.Sum);
            Console.WriteLine(e.Message);
        }

        private static void Print(string message, Func<string, string> beforePrintingAction)
        {
            var changedMessage = beforePrintingAction(message);

            Console.WriteLine(changedMessage);
        }
    } 
}
