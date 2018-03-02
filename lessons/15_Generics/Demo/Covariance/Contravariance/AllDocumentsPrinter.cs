using System;

namespace Contravariance
{
    public class AllDocumentsPrinter : IContravariantPrinter<BaseDocument>
    {
        public AllDocumentsPrinter()
        {
            CurrentDocumentType = new PDFDocument { DocumentName = "Default document" };
        }

        public void Print(BaseDocument document)
        {
            Console.WriteLine(document);
        }

        public object PrintColour(BaseDocument document)
        {
            Console.WriteLine(document);

            return "Colour document was printed. Current document type: " + CurrentDocumentType.GetType().Name;
        }

        public BaseDocument CurrentDocumentType { get; set; }
    }
}