using System;
using System.Collections.Generic;
using System.Text;

namespace array_methods
{
    class ArrayMethods
    {
        private int[] _array;
        private int[] newArray;

        public ArrayMethods(int[] array)
        {
            _array = array;
        }

        public void Add(int value)
        {
           newArray = new int[_array.Length + 1];

            for (var i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            newArray[_array.Length] = value;
        }

        public bool Contains(int value)
        {
            foreach(int val in _array)
            {
                if(val == value)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetByIndex(int value)
        {
            return _array[value];
        }

        public void PrintArrya()
        {
            if( newArray == null || newArray.Length == 0)
            {
                return;
            }
            foreach (int val in newArray)
            {
                Console.Write("{0} ", val);
            }
            Console.WriteLine();
        }
    }
}
