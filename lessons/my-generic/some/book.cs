using System;
using System.Collections.Generic;
using System.Text;

namespace some
{
    class Book
    {
        public string title { get; }
        public Book(string book)
        {
            title = book;
        }

        public void ShowContent()
        {
            Console.WriteLine(title);
        }
    }
}
