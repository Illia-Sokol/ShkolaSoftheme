using System;
using System.Collections.Generic;

namespace BinaryTree
{
    class TreeEnumerator<TItem> : IEnumerator<TItem> where TItem : IComparable<TItem>
    {
        private readonly Tree<TItem> _currentData;
        
        private TItem _currentItem;
        
        private Queue<TItem> _enumData;

        public TreeEnumerator(Tree<TItem> data)
        {
            _currentData = data;
        }

        private void Populate(Queue<TItem> enumQueue, Tree<TItem> tree)
        {
            if (tree.LeftTree != null)
            {
                Populate(enumQueue, tree.LeftTree);
            }

            enumQueue.Enqueue(tree.NodeData);

            if (tree.RightTree != null)
            {
                Populate(enumQueue, tree.RightTree);
            }
        }

        public TItem Current
        {
            get
            {
                if (_enumData == null)
                {
                    throw new InvalidOperationException("Use MoveNext before calling Current");
                }

                return _currentItem;
            }
        }

        void IDisposable.Dispose()
        {
            // throw new NotImplementedException();
        }

        object System.Collections.IEnumerator.Current
        {
            get { return Current; }
        }

        bool System.Collections.IEnumerator.MoveNext()
        {
            if (_enumData == null)
            {
                _enumData = new Queue<TItem>();
                Populate(_enumData, _currentData);
            }

            if (_enumData.Count > 0)
            {
                _currentItem = _enumData.Dequeue();
                return true;
            }

            return false;
        }

        void System.Collections.IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
