using System;
using System.Collections.Generic;

namespace AdapterPatternDemo
{   
    class Program
    {
        static void Main(string[] args)
        {
            //In this demo assume Employee and consultant are independent classes and there is no internal link.
            //Now we might want to consume Employee's functionality for Consultent without making any chane to both classes.
            //So create an adapter wrapper class and invoke the required functionality.

            List<IEmployee> list = new List<IEmployee>();
            //Assume Existing functionality.
            list.Add(new Employee("Sai"));
            list.Add(new Employee("Sri"));

            //Added/injected wrapper to connect both Employee and Consultant.
            list.Add(new ConsultantToEmployeeAdapter("SaiSri"));  //consultant from existing class

            //Assume Existing functionality, will not break or no changes to be made.
            ShowHappiness(list);

            Console.ReadLine();
        }

        //Code below from the existing library does not need to be changed
        static void ShowHappiness(List<IEmployee> list)
        {
            foreach (IEmployee i in list)
                i.ShowHappiness();
        }
    }
}