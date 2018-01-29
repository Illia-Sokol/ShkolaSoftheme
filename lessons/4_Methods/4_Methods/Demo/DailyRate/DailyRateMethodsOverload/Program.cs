using System;

namespace DailyRateMethodsOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            double fee;

            var paymentOptionInHours = IsEployeeGetPayedInHours();
            if (paymentOptionInHours)
            {
                fee = CalculateFee(ReadDouble("Enter your daily rate: "),
                                   ReadInt("Enter the number of days: "),
                                   ReadInt("Enter the number of hours per day: "));
            }
            else
            {
                fee = CalculateFee(ReadDouble("Enter your daily rate: "),
                                   ReadInt("Enter the number of days: "));
            }

            WriteFee(fee);
        }

        private static bool IsEployeeGetPayedInHours()
        {
            Console.WriteLine("Please choose payment option: \n H for payment per hour \n D for payment per day");
            char paymentOption = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (paymentOption.ToString().ToUpperInvariant())
            {
                case "H":
                    return true;
                case "D":
                    return false;
                default:
                    throw new ArgumentException("Wrong Payment Option");
            }
        }

        private static void WriteFee(double p)
        {
            Console.WriteLine("The consultant's fee is: {0}", p * 1.1);
        }

        private static double CalculateFee(double dailyRate, int noOfDays)
        {
            return dailyRate * noOfDays;
        }

        private static double CalculateFee(double hourlyRate, int noOfDays, int noOfHours)
        {
            return hourlyRate * noOfDays * noOfHours;
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
