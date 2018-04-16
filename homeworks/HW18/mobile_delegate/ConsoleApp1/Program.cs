using System;

namespace Mobile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var account1 = new MobileAccount(12345);
            var account2 = new MobileAccount(23456);
            using (var @operator = new MobileOperator())
            {
                @operator.AddAccount(account1);
                @operator.AddAccount(account2);

                account1.Call(23456);
                account1.SendSms(23456, "Test message");
            }
        }
    }
}
