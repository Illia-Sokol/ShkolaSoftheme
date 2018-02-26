using System;

namespace _05_Dispose_pattern
{
    class Program
    {
        static void Main()
        {
            using (var resourseHolder = new DisposableResourceHolder())
            {
                resourseHolder.DoSomeAction();
            }

            Console.ReadKey();
        }
    }
}
