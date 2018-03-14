using System;

namespace Delegates_02
{
    class Program
    {
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            Operation operation = new Operation(Add);
            int result = operation.Invoke(4, 5);
            Console.WriteLine(result);

            operation = Multiply;
            result = operation.Invoke(4, 5);
            Console.WriteLine(result);

            Console.Read();
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
