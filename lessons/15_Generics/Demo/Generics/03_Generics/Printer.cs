using System;

namespace _03_Generics
{
    public class Printer<TDocument>
           where TDocument : IDocument
    {
        private readonly TDocument[] _documents;

        public Printer(params TDocument[] documents)
        {
            _documents = documents;
        }

        public void PrintDocuments()
        {
            for (var i = 0; i < _documents.Length; i++)
            {
                var document = _documents[i];

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Document{0} : {1}", i + 1, document.Name);
                Console.WriteLine("Document text: ");
                Console.ResetColor();

                Console.WriteLine(document.GetAllInfo());
                Console.WriteLine();
            }
        }

        public void PrintDocumentNames()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Document names: ");

            foreach (var document in _documents)
            {
                Console.WriteLine(document.Name);
            }

            Console.ResetColor();
            Console.WriteLine();
        }
    }
}