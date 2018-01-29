using System;

namespace DailyRateOptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            double dailyRate = ReadDouble("Enter your daily rate: ");
            int noOfDays = ReadInt("Enter the number of days: ");
            double fee;
            if (dailyRate.Equals(default(double)) && noOfDays.Equals(default(int)))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Daily rate and number of days was not specified. Will be using stored values.");
                Console.ResetColor();
                fee = CalculateFee();
            }
            else
            {
                fee = CalculateFee(dailyRate, noOfDays);
            }

            WriteFee(fee);
        }

        private static void WriteFee(double p)
        {
            Console.WriteLine("The consultant's fee is: {0}", p * 1.1);
        }

        private static double CalculateFee(double dailyRate = 10.0, int noOfDays = 20)
        {
            return dailyRate * noOfDays;
        }

        private static int ReadInt(string p)
        {
            Console.Write(p);
            string line = Console.ReadLine();
            return string.IsNullOrEmpty(line) ? 0 : int.Parse(line);
        }

        private static double ReadDouble(string p)
        {
            Console.Write(p);
            string line = Console.ReadLine();
            return string.IsNullOrEmpty(line) ? 0.0 : double.Parse(line);
        }
    }
}
