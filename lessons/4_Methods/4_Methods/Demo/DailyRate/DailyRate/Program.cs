using System;

namespace DailyRate
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
            WriteFee(CalculateFee(dailyRate, noOfDays));
        }

        private static void WriteFee(double p)
        {
            Console.WriteLine("The consultant's fee is: {0}", p * 1.1);
        }

        private static double CalculateFee(double dailyRate, int noOfDays)
        {
            return dailyRate * noOfDays;
        }

        private static int ReadInt(string p)
        {
            Console.Write(p);
            string line = Console.ReadLine();
            return int.Parse(line);
        }

        private static double ReadDouble(string p)
        {
            Console.Write(p);
            string line = Console.ReadLine();
            return double.Parse(line);
        }
    }
}
