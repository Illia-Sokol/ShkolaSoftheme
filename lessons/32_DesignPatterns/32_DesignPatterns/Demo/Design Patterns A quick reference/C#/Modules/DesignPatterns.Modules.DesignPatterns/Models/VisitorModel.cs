using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Modules.Models
{
    public class Salary : ISaving
    {
        public int Amount { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class HomeRent : ISaving
    {
        public int RentAmount { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class CreditCardBill : ISaving
    {
        public int Bill { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public interface IVisitor
    {
        void Visit(Salary salary);
        void Visit(HomeRent rent);
        void Visit(CreditCardBill bill);
    }

    public interface ISaving
    {
        void Accept(IVisitor visitor);
    }

    public class Employee : ISaving
    {
        public List<ISaving> Savings = new List<ISaving>();

        public void Accept(IVisitor visitor)
        {
            foreach (var items in Savings)
            {
                items.Accept(visitor);
            }
        }
    }

    public class SavingVisitor : IVisitor
    {
        public int Balance { get; set; }
        public void Visit(Salary salary)
        {
            Balance += salary.Amount;
        }

        public void Visit(HomeRent rent)
        {
            Balance -= rent.RentAmount;
        }

        public void Visit(CreditCardBill bill)
        {
            Balance -= bill.Bill;
        }
    }
}
