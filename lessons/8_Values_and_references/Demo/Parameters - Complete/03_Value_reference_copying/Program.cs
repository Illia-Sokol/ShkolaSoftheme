using System;

namespace _03_Value_reference_copying
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Harry Potter and the Philosopher’s Stone ", "Joanne Rowling", 357);
            var bookCopy = book;

            PrintBookInfo(book);
            PrintBookInfo(bookCopy);

            bookCopy.Pages = 111;

            PrintBookInfo(book, ConsoleColor.Yellow);
            PrintBookInfo(bookCopy, ConsoleColor.Yellow);
        }

        static void PrintBookInfo(Book book, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("Name: {0}, Author: {1}, Pages: {2}", book.Name, book.Author, book.Pages);
            Console.ResetColor();
        }
    }
}
