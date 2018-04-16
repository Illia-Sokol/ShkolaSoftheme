using System;

namespace BankSubSystemLibrary
{
    class SubSystemLoan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }  
}