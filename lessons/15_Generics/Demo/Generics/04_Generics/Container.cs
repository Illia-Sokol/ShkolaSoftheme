namespace _04_Generics
{
    public class Container<T> : IContainer<T>
    {
        private readonly T _item;

        public Container(T item)
        {
            _item = item;
        }

        public T GetItem()
        {
            return _item;
        }
    }
}