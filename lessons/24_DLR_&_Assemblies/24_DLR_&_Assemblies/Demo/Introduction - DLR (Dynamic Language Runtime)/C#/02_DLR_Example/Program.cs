using System;

namespace _02_DLR_Example
{
    class Program
    {
        static void Main()
        {
            var a = "String";
            object b = "SomeString";
            dynamic c = "AllString";
            Console.WriteLine("a: " + a.GetType() + "\nb: " + b.GetType() + "\nc: " + c.GetType());

            object obj = 24;
            dynamic dyn = 24;
            
            //obj += 4;
            dyn += 4;

            //DynamicData();

            Console.ReadLine();
        }

        static void DynamicData()
        {
            dynamic textData = "Hello";
            Console.WriteLine(textData.ToUpper());

            Console.WriteLine(textData.ToUpper());
            Console.WriteLine(textData.Foo(10, "ее", DateTime.Now));
        }
    }
}
