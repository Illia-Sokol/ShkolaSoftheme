using System;

namespace _07_Virtual
{
    public class MyDerivedClass : MyBaseClass
    {
        public override void DoSomeAction()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Action from derived class");
            Console.ResetColor();
        }
    }
}