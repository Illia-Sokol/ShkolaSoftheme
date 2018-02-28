using System;

namespace _04_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLib = new Library();

            Print(ref myLib[0]);

            Print(ref myLib.Books[0]);
        }

        private static void Print(ref string text)
        {
            Console.WriteLine(text);
        }

    

        internal class Library
        {
            public string[] Books;

            public Library()
            {
                Books = new[] { "Отцы и дети",
                                "Война и мир",
                                "Евгений Онегин" };
            }

            public int Length
            {
                get { return Books.Length; }
            }

            public string this[int index]
            {
                get { return Books[index]; }
                set { Books[index] = value; }
            }
        }
    }
}
