using System;

namespace _04_Value_reference_nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Harry Potter and the Philosopher’s Stone ", "Joanne Rowling", 357);
            var invalidBook = new Book(null, null);

            PrintBookInfo(book);

            PrintBookInfo(invalidBook, ConsoleColor.Green);

            Console.WriteLine();
        }

        static void PrintBookInfo(Book book, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("Book info:");
            
            if (!string.IsNullOrEmpty(book.Name))
            {
                Console.Write("Name: {0}\n", book.Name);
            }

            if (!string.IsNullOrEmpty(book.Author))
            {
                Console.Write("Author: {0}\n", book.Author);
            }

            if (book.Pages != 0)
            {
                Console.Write("Pages: {0}\n", book.Pages);
            }
            
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
