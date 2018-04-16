using System;

namespace Mobile
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new MobileAccount(12345);
            var account2 = new MobileAccount(23456);
           
            var mobileOperator = new MobileOperator();

            mobileOperator.AddAccount(account1);
            mobileOperator.AddAccount(account2);

            account1.Call(23456);
            account1.Call(234522336);
            account1.SendSms(23456, "Test message");
        }
    }
}
