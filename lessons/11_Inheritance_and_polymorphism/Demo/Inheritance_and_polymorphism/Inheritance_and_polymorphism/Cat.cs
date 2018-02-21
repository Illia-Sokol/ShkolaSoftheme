using System;

namespace Inheritance_and_polymorphism
{
    public class Cat : Animal
    {
        public override bool IsMammal
        {
            get { return true; }
        }

        public void Meow()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Meow\n");
            Console.ResetColor();
        }
    }
}