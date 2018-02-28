using System.Linq;

namespace _03_Indexers
{
    internal class Program
    {
        private static void Main()
        {
        }
    }

    internal class Library
    {
        private Book[] books;

        public Library()
        {
            books = new[]
            {
                new Book("Отцы и дети"),
                new Book("Война и мир"),
                new Book("Евгений Онегин")
            };
        }

        public int Length
        {
            get { return books.Length; }
        }

        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        public Book this[string bookName]
        {
            get { return books.FirstOrDefault(book => book.Name.Equals(bookName)); }
        }
    }
}
