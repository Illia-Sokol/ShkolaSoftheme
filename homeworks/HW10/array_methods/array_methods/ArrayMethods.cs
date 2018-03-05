using System;
using System.Collections.Generic;
using System.Text;

namespace array_methods
{
    class ArrayMethods
    {
        private int[] _array;

        public ArrayMethods(int[] array)
        {
            _array = array;
        }

        public void Add(params int[] list)
        {
            //_array = new int[] { value};
            //_array = new int[]
            var arrayLength = _array.Length + list.Length;
            var array = new int[arrayLength];
            var listIterator = 0;
            for (var i = 0; i < _array.Length + list.Length; i++)
            {
                if(i < arrayLength)
                {
                    array[i] = _array[i];
                }
                else
                {
                    array[i] = list[listIterator];
                    listIterator++;
                }
            }
            _array = new int [5];
            _array[0] = 3;
            _array[4] = 6;
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
            foreach (int val in _array)
            {
                Console.Write("{0} ", val);
            }
            Console.WriteLine();
        }
    }
}
