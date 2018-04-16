using System;
using System.Collections.Generic;

namespace StrategyOrPolicyDesignPattern
{
    class Program
    {
        static void Main()
        {
            DemoClient();
        }

        private static void DemoClient()
        {
            //Deal and Interact with Context.
            SortContext SortContextObj = new SortContext();

            SortContextObj.Add("Sai");
            SortContextObj.Add("Sri");
            SortContextObj.Add("SaiSri");
            SortContextObj.Add("SriMahi");
            SortContextObj.Add("SaiSriMahi");

            //Specify the strategy to be used.
            SortContextObj.SetSortStrategy(SortStrategyType.QuickSort);
            SortContextObj.Sort();
            SortContextObj.Display();

            SortContextObj.SetSortStrategy(SortStrategyType.MergeSort);
            SortContextObj.Sort();
            SortContextObj.Display();

            SortContextObj.SetSortStrategy(SortStrategyType.ShellSort);
            SortContextObj.Sort();
            SortContextObj.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}