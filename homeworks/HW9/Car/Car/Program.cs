using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var tt = new CarConstructor();
            Car car = tt.Construct(
                new Engine(EngineTypes.Diesel), 
                new Color(ColorSchema.Silver),
                new Transmission(TransmissionTypes.Automat));
            Console.WriteLine("Car: {0}, {1}, {2}", 
                car.Color.CarColor, car.Engine.EngineType, car.Transmission.TransmissionType);

            Car car2 = car;
            car2.ChangeEngine(new Engine(EngineTypes.Petrol));
            Console.WriteLine("Car: {0}; Car2: {1}", car.Engine.EngineType, car2.Engine.EngineType);

            Car car3 = tt.Reconstruct(car, new Engine(EngineTypes.Oil));
            Console.WriteLine("Car: {0}; Car3: {1}", car.Engine.EngineType, car3.Engine.EngineType);
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
