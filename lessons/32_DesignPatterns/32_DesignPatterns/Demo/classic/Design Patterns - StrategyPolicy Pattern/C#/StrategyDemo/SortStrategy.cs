using System.Collections.Generic;

namespace StrategyOrPolicyDesignPattern
{
    abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
