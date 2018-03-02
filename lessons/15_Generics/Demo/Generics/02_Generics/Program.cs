using System;

namespace _02_Generics
{
    class Program
    {
        static void Main()
        {
            var myTuple = new GenericTuple<int, string, bool[]>(44,
                                                                "Softheme",
                                                                new[] { true, false, true });

            var singleTuple = new Tuple<int, string, bool[]>(44,
                                                             "Softheme",
                                                             new[] { true, false, true });

            Console.WriteLine(singleTuple.Item1);

            Console.WriteLine(myTuple);

            Console.ReadKey();
        }
    }
}
