using System;

namespace _04_Delegates
{
    delegate int Calculate(int number);

    class Program
    {
        static void Main()
        {
            Calculate calculateDelegate = GetCalculationDelegate();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Calculation of {0} equals: {1}", i, calculateDelegate.Invoke(i));
            }

            Console.ReadLine();
        }

        static Calculate GetCalculationDelegate()
        {
            Calculate calculateDelegate = delegate(int number)
            {
                var result = number * number;
                return result;
            };

            return calculateDelegate;
        }
    }
}
