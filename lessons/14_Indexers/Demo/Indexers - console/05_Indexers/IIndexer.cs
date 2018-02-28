namespace _03_Indexers
{
    interface IIndexer
    {
        bool this[int index] { get; set; }
    }
}