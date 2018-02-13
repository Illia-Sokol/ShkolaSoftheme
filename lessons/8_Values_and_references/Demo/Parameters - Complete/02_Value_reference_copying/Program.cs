using System;

namespace _02_Value_reference_copying
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = 5;
            var valueCopy = value;

            PrintNumbers(value, valueCopy);

            valueCopy++;

            PrintNumbers(value, valueCopy);
        }

        static void PrintNumbers(params int[] values)
        {
            for (var i = 0; i < values.Length; i++)
            {
                Console.WriteLine("Value {0}: {1}", i, values[i]);
            }

            Console.WriteLine("\n--------------------------\n");
        }
    }
}
