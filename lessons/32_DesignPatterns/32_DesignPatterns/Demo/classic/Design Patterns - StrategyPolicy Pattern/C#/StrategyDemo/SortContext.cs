using System;
using System.Collections.Generic;

namespace StrategyOrPolicyDesignPattern
{
    public class SortContext
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortstrategy;

        public void SetSortStrategy(SortStrategyType sortstrategyType)
        {
            if (sortstrategyType == SortStrategyType.QuickSort)
            {
                this._sortstrategy = new QuickSort();
            }
            else if (sortstrategyType == SortStrategyType.MergeSort)
            {
                this._sortstrategy = new MergeSort();
            }
            else if (sortstrategyType == SortStrategyType.ShellSort)
            {
                this._sortstrategy = new ShellSort();
            }
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            //Calling the Sort based on the Strategy.
            _sortstrategy.Sort(_list);
        }

        public void Display()
        {
            // Iterate over list and display results
            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }

            Console.WriteLine();
        }
    }
}
