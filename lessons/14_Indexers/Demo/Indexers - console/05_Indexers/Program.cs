using System;

namespace _03_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            IIndexer indexer = new IndexerImplementation();

            var indexIsValid = indexer[0];

            Console.WriteLine("Index is valid: {0}", indexIsValid);

            //indexer[-1] = false;

            Console.ReadKey();
        }
    }
}
