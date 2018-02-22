using System;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Opel", 1989, "green");
            Console.WriteLine("{0}", car.Color);

            new TuningCar().TuningCarColor(car, "pink");
            Console.WriteLine("{0}", car.Color);
        }
    }
}
