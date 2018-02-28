using System;

namespace _03_Indexers
{
    class IndexerImplementation : IIndexer
    {
        public bool this[int index]
        {
            get { return index > 0; }
            set { throw new NotImplementedException(); }
        }
    }
}