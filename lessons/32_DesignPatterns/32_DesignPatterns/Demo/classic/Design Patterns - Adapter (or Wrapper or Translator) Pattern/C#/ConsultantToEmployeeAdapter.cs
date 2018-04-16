using System;
using System.Collections.Generic;


namespace AdapterPatternDemo
{
    public class ConsultantToEmployeeAdapter : Consultant, IEmployee
    {
        public ConsultantToEmployeeAdapter(string name)
            : base(name)
        {
        }
        // Employee.ShowHappiness integrated to invoke the Consultant.ShowSmile
        void IEmployee.ShowHappiness()
        {
            base.ShowSmile();  //call the parent Consultant class
        }
    }
}