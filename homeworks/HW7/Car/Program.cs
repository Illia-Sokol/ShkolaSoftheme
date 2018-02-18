using System;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Opel", 1989, "green");
            Console.WriteLine("{0}", car._model);
            var tuningCar = new TuningCar().TuningCarColor("Audi", 1999);
            Console.WriteLine("{0}", tuningCar._model);
        }
    }
}
