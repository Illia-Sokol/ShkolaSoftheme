using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankSubSystemLibrary;
namespace FacadePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Facade
            FacadeMortgage mortgage = new FacadeMortgage();
            
            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("SaiSriMahi");
            bool eligible = mortgage.IsEligible(customer, 125000);
            
            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));
            
            // Wait for user
            Console.ReadKey();
        }
    }
}
