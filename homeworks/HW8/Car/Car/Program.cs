using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var tt = new CarConstructor();
            Car car = tt.Construct(new Engine("Diesel"), new Color("red"), new Transmission());
            Console.WriteLine("{0}", car.Engine.EngineType);

            car = tt.Reconstruct(car, new Engine("Petrol"));
            Console.WriteLine("{0}", car.Engine.EngineType);
            Console.ReadKey();
        }
    }
}
