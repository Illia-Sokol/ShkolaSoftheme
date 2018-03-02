namespace Contravariance
{
    public interface IContravariantPrinter<in TDocument> // TDocument is contravariant for all members of interface.
    {
        void Print(TDocument document);

        object PrintColour(TDocument document);

        TDocument CurrentDocumentType { set; }
    }
}