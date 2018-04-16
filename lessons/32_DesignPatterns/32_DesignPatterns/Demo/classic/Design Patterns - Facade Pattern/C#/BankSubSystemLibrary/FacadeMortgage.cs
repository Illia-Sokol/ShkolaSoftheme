using System;

namespace BankSubSystemLibrary
{
    public class FacadeMortgage
    {
        private SubSystemBank _bank = new SubSystemBank();
        private SubSystemLoan _loan = new SubSystemLoan();
        private SubSystemCredit _credit = new SubSystemCredit();

        public bool IsEligible(Customer cust, int amount)
        {

            Console.WriteLine("{0} applies for {1:C} loan\n", cust.Name, amount);
            bool eligible = true;

            // Check creditworthyness of applicant
            if (!_bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }

            else if (!_loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }

            else if (!_credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}