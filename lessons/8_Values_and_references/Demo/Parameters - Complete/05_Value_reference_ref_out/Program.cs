using System;

namespace _05_Value_reference_ref_out
{
    class Program
    {
        static void Main()
        {
            var operand1 = 8;
            var operand2 = 25;
            int result;

            Multiply(operand1, ref operand2, out result);

            Console.WriteLine("operand1: {0}, operand2: {1}, result: {2}",
                               operand1, 
                               operand2,
                               result);

            Console.ReadKey();
        }

        private static void Multiply(int operand1, ref int operand2, out int result)
        {
            operand2++;
            result = operand1 * operand2;
        }
    }
}
