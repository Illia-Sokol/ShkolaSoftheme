using System;

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            var library = new Library();

            ShowLibraryInfo(library);

            library[0] = new Book("Interesting book");

            ShowLibraryInfo(library);

            Console.ReadLine();
        }

        private static void ShowLibraryInfo(Library library)
        {
            Console.WriteLine("Library contains {0} books.", library.Length);
            for (var i = 0; i < library.Length; i++)
            {
                Book currentBook = library[i];
                Console.WriteLine(currentBook.Name);
            }
            Console.WriteLine();
        }
    }
}
