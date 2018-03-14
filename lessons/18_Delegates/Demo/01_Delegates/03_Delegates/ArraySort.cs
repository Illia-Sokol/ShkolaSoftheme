using System;
using System.Collections.Generic;

namespace _03_Delegates
{
    class ArraySort
    {
        public static void Sort<T>(IList<T> sortArray, Func<T, T, bool> comparisonFunc)
        {
            bool sorting;

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