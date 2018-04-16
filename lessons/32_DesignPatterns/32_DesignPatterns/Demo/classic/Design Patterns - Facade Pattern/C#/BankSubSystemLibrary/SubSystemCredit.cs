using System;

namespace BankSubSystemLibrary
{  
    class SubSystemCredit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }
}