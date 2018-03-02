using System;

namespace _05_Generics
{
    public class Account
    {
        private static readonly Random Rnd = new Random();

        public void DoTransfer()
        {
            var sum = Rnd.Next(10, 120);
            Console.WriteLine("The client put into the account {0} dollars", sum);
        }
    }
}