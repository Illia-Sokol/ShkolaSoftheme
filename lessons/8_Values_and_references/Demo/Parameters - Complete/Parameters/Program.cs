using System;

namespace Parameters
{
    class Program
    {
        static void DoWork()
        {
            var i = 0;
            
            Console.WriteLine(i);
            RandomGenerator.UpdateValueType(ref i);
            Console.WriteLine(i);

            WrappedInt wi = new WrappedInt();

            Console.WriteLine(wi.Number);
            RandomGenerator.Reference(wi);
            Console.WriteLine(wi.Number);
        }

        static void Main(string[] args)
        {
            try
            {
                DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
