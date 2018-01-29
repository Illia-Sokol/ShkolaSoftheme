using System;

namespace DailyRateRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            var fee = CalculateFee(ReadDouble("Enter your daily rate: "),
                                   ReadInt("Enter the number of days: "),
                                   ReadInt("Enter the number of hours per day: "));

            WriteFee(fee);
        }

        private static void WriteFee(double p)
        {
            Console.WriteLine("The consultant's fee is: {0}", p * 1.1);
        }

        private static double CalculateFee(double hourlyRate, int noOfDays, int noOfHours)
        {
            if (hourlyRate.Equals(default(double)))
            {
                return CalculateFee(10, noOfDays, noOfHours);
            }
            
            if (noOfDays.Equals(default(int)))
            {
                return CalculateFee(hourlyRate, 20, noOfHours);
            }
            
            if (noOfHours.Equals(default(int)))
            {
                return CalculateFee(hourlyRate, noOfDays, 1);
            }

            return hourlyRate * noOfDays * noOfHours;
        }

        private static int ReadInt(string p)
        {
            Console.Write(p);
            string line = Console.ReadLine();
            return string.IsNullOrEmpty(line) ? default(int) : int.Parse(line);
        }

        private static double ReadDouble(string p)
        {
            Console.Write(p);
            string line = Console.ReadLine();
            return string.IsNullOrEmpty(line) ? default(double) : double.Parse(line);
        }
    }
}
