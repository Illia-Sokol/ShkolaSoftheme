using System;

namespace _03_Classes_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageToPrint = "Hello world";
            
            Console.WriteLine(messageToPrint);
            
            ConsolePrintHelper.PrintFancyStringMessage(messageToPrint);
            
            Console.WriteLine(messageToPrint);

            Console.ReadKey();
        }
    }

    public static class ConsolePrintHelper
    {
        public static void PrintFancyStringMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
