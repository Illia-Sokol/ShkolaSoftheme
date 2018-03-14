using System;
using System.IO;

namespace Delegates
{
    class Program
    {
        delegate void LogInfoDelegate(string message);

        static void Main(string[] args)
        {
            LogInfoDelegate log;

            Console.WriteLine("Input 'f' for file write or 'c' for console write: ");
            var input = Console.ReadKey();
            switch (input.KeyChar)
            {
                case 'f':
                    log = WriteFile;
                    break;
                case 'c':
                    log = PrintConsoleRed;
                    break;
                default:
                    throw new InvalidOperationException("Incorrect input");
            }

            log.Invoke("Hello world");

            Console.ReadKey();
        }

        private static void PrintConsoleRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Concat(Environment.NewLine, message));
            Console.ResetColor();
        }

        private static void WriteFile(string message)
        {
            using (var writer = new StreamWriter("log.txt", true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
