using System;

namespace _05_Extensions
{
    public static class CarExtensions
    {
        public static void DisplayFullInfo(this Car car)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var message = string.Format("Car model: {0}, colour: {1}", car.Model, car.Colour);
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}