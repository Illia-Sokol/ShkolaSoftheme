namespace _04_Indexers
{
    interface ICoordinatesIndexer
    {
        bool this[int x, int y, int z] { get; set; }
    }
}