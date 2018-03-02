using System;

namespace _03_Generics
{
    class Program
    {
        static void Main()
        {
            var pdfDocument = new PdfDocument { Body = "Some text and images", Footer = "footer info", Header = "header info", Name = "Salary.pdf" };
            var txtDocument = new TxtDocument { Body = "Some text and only text", Footer = "footer info", Header = "header info", Name = "Passwords.txt" };

            var printer = new Printer<IDocument>(pdfDocument, txtDocument);

            printer.PrintDocumentNames();

            printer.PrintDocuments();

            Console.ReadKey();
        }
    }
}
