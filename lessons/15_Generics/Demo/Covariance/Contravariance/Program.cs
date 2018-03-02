using System;

namespace Contravariance
{
    class Program
    {
        // Благодаря контравариантности интерфейсов мы можем присвоить переменной интерфейса параметризированной производным типом PDFDocument
        // интерфейс параметризированный базовым типом BaseDocument (екземпляр класса реализующего интерфейс параметризированный базовым типом BaseDocument),
        // при условии что все входящие параметры методов и свойств будут типом который,
        // базовый от того типа, который является параметром базового интерфейса.
        static void Main(string[] args)
        {
            IContravariantPrinter<PDFDocument> derivedPrinter = default(IContravariantPrinter<PDFDocument>);
            IContravariantPrinter<BaseDocument> basePrinter = default(IContravariantPrinter<BaseDocument>);
            basePrinter = new AllDocumentsPrinter();

            // Contravariance: Derived "is a" Base => IContravariantPrinter<BaseDocument> "is a" IContravariantPrinter<PDFDocument>.
            derivedPrinter = basePrinter;

            // When calling derivedPrinter.Print, the underlying basePrinter.Print executes.
            // basePrinter.Print method (Action<Base>) "is a" derivedPrinter.Print method (Action<Derived>).
            derivedPrinter.Print(new PDFDocument { DocumentName = "Derived PDF 1" });

            // When calling derivedPrinter.PrintColour, the underlying basePrinter.PrintColour executes.
            // basePrinter.PrintColour (Func<Base, object>) "is a" derivedPrinter.PrintColour (Func<Derived, object>).
            object someResult = derivedPrinter.PrintColour(new PDFDocument { DocumentName = "Derived PDF 2" });

            Console.WriteLine(someResult as string);

            // In3 property is setter only. The setter is a set_CurrentDocumentType method (Action<TOut>).
            // basePrinter.CurrentDocumentType setter (Action<Base>) "is a" derivedPrinter.CurrentDocumentType setter (Action<Base>).
            derivedPrinter.CurrentDocumentType = new PDFDocument();

            // So, IContravariantPrinter<Base> interface "is an" IContravariantPrinter<Derived> interface. Above binding always works.
        }
    }
}
