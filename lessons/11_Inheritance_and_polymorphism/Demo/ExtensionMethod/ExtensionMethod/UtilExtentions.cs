using System;

namespace ExtensionMethod
{
    static class UtilExtentions
    {
        public static int ConvertToBase(this int i, int baseToConvertTo, ConsoleColor consoleColor)
        {
            if (baseToConvertTo < 2 || baseToConvertTo > 10)
            {
                throw new ArgumentException("Value cannot be converted to base " + baseToConvertTo);
            }

            var result = 0;
            var iterations = 0;
            do
            {
                var nextDigit = i % baseToConvertTo;
                i /= baseToConvertTo;
                result += nextDigit * (int)Math.Pow(10, iterations);
                iterations++;
            }
            while (i != 0);

            Console.ForegroundColor = consoleColor;
            Console.WriteLine(result);
            Console.ResetColor();

            return result;
        }
    }
}