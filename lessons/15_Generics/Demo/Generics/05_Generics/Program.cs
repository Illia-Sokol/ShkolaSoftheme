using System;

namespace _05_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            IBank<Account> ordinaryBank = new Bank<Account>();
            ordinaryBank.DoOperation(account);

            DepositAccount depositAccount = new DepositAccount();

            IBank<DepositAccount> depositBank = ordinaryBank;
            depositBank.DoOperation(depositAccount);

            Console.ReadLine();
        }
    }
}
