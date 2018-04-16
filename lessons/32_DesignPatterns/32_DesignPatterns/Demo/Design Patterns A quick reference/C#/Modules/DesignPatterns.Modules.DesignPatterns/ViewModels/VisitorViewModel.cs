using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Common;
using DesignPatterns.Modules.Models;

namespace DesignPatterns.Modules.ViewModels
{
    public class VisitorViewModel : ViewModelBase
    {

        private string savings;

        public string Savings
        {
            get
            {
                return this.savings;
            }
            set
            {
                this.savings = value;
                this.OnPropertyChanged("Savings");
            }
        }


        public VisitorViewModel()
        {

            var employee = new Employee();
            employee.Savings.Add(new Salary { Amount = 50000 });
            employee.Savings.Add(new HomeRent { RentAmount = 15000 });
            employee.Savings.Add(new CreditCardBill { Bill = 20000 });

            var savingsVisitor = new SavingVisitor();
            employee.Accept(savingsVisitor);

            this.Savings = Convert.ToString(savingsVisitor.Balance);
        }
    }
}
