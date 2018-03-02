using System;

namespace Generics
{
    class GenericValueWrapper<TValue>
    {
        readonly TValue _value;

        public GenericValueWrapper(TValue value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public void PrintObjectType()
        {
            Console.WriteLine("Object type: " + typeof(TValue));
        }
    }
}