using System;

namespace _05_Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Citroen", "Blue");
            car.DisplayFullInfo();

            Console.ReadKey();
        }
    }
}
