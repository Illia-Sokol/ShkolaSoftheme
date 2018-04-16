using System;
using System.Collections.Generic;

namespace AdapterPatternDemo
{
    public class Employee : IEmployee
    {
        private string name;

        public Employee(string name)
        {
            this.name = name;
        }

        void IEmployee.ShowHappiness()
        {
            Console.WriteLine("Employee " + this.name + " is happy");
        }
    }  
}
