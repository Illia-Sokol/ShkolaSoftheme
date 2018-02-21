using System;

namespace Inheritance_and_polymorphism
{
    public class Snake : Animal
    {
        public override bool IsMammal
        {
            get { return false; }
        }

        public void ShedSkin()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Shed a skin\n");
            Console.ResetColor();
        }
    }
}
