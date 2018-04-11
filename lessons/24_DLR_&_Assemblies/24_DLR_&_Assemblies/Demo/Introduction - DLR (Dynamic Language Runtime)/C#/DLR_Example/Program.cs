using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic; 

namespace DLR_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic myDynamicVariable;
            // "dynamic" is keywork for declaring dynamic type variables 
            var _objClass = new Class1();
            
            // Creating object 
            myDynamicVariable = _objClass;

            myDynamicVariable.displayNumeric();

            myDynamicVariable = _objClass.displayMessage();
            Console.WriteLine("Value: " + myDynamicVariable + ". Type of dynamic variable is: " + myDynamicVariable.GetType());
            // Displaying types

            myDynamicVariable = _objClass.displayNumeric();
            Console.WriteLine("\nValue: My CP Member Id # " + myDynamicVariable + ". Type of dynamic variable is: " + myDynamicVariable.GetType());
            // Displaying types
            
            Console.ReadLine();
        }
        
        
        class Class1
        {
            private string sMessage = "The Code Project is COOL";
            public string displayMessage()
            {
                return sMessage;
            }
            public int displayNumeric()
            {
                return 1186309;
            }
        }

    }
}
