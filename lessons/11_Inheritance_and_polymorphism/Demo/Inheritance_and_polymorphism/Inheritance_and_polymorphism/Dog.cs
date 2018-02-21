using System;

namespace Inheritance_and_polymorphism
{
    public class Dog : Animal
    {
        public override bool IsMammal
        {
            get { return true; }
        }

        public void Fetch()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Fetch a stick\n");
            Console.ResetColor();
        }
    }
}
