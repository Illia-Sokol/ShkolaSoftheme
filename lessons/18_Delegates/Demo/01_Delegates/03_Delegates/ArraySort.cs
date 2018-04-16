using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Delegates
{
    class ArraySort
    {
        public static void Sort<T>(IList<T> sortArray, Func<T, T, bool> comparisonFunc)
        {
            bool sorting;
            var list = new List<int> { 1, 2, 3 };
            var list2 = list.ToList();
            do
            {
                sorting = false;
                for (int i = 0; i < sortArray.Count - 1; i++)
                {
                    var comparationResult = comparisonFunc(sortArray[i + 1], sortArray[i]);

                    Console.WriteLine(comparationResult);

                    if (comparationResult)
                    {
                        T j = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = j;
                        sorting = true;
                    }
                }
            }
            while (sorting);
        }
    }
}