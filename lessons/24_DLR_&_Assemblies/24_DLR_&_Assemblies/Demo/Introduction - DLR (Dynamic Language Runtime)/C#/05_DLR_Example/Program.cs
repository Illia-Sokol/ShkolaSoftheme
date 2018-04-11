using System;
using System.Collections.Generic;

namespace _05_DLR_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic viewbag = new System.Dynamic.ExpandoObject();
            viewbag.Name = "Tom";
            viewbag.Age = 46;
            viewbag.Languages = new List<string> { "english", "german", "french" };
            
            Console.WriteLine("{0} - {1}", viewbag.Name, viewbag.Age);

            foreach (var lang in viewbag.Languages)
            {
                Console.WriteLine(lang);

            }

            viewbag.IncrementAge = (Action<int>)(x => viewbag.Age += x);
            viewbag.IncrementAge(6);
            
            Console.WriteLine("{0} - {1}", viewbag.Name, viewbag.Age);
        }
    }
}
