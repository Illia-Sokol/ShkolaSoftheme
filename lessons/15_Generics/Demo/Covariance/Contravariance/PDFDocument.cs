using System.Globalization;

namespace Contravariance
{
    public class PDFDocument : BaseDocument
    {
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "Document type: PDF, document name: {0}", DocumentName);
        }
    }
}