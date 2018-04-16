using System;
using System.Collections.Generic;

namespace StrategyOrPolicyDesignPattern
{
    class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("ShellSorted list ");
        }
    }
}
