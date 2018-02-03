using System;

namespace @goto
{
    class Program
    {
        static void Main(string[] args)
        {

        labelStart: //creating label with colon(:)

            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Welcome {0}", name);

            if (name != "Bob")
            {
                goto labelStart; //jump to label statement       
            }

            Console.WriteLine("Good bye Bob!");
            Console.ReadKey();
        }
    }
}