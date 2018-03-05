using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main()
        {
            var numbers = new List<int> { 11, 28, 3333, 405, 99 };

            numbers.Add(22);

            numbers.AddRange(new[] { 7, 8, 9 });

            numbers.Insert(0, 666);

            numbers.RemoveAt(1);

            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

            var books = new List<Book>();

            books.Add(new Book { Name = "BookName1", Author = "Author1" });
            books.Add(new Book { Name = "BookName2", Author = "Author2" });

            foreach (var book in books)
            {
                Console.WriteLine(book.Name);
            }

            Console.ReadLine();
        }
    }
}
