using System;

namespace _03_Substitution
{
    public class MyDerivedClass : MyBaseClass
    {
        public new void DoSomeAction()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Action from derived class");
            Console.ResetColor();
        }
    }
}