using System;

namespace Interfaces_vehicle
{
    class Program
    {
        static void Main()
        {
            IVehicle myCar = new Car(wheels: 4,
                                         topSpeed: 200,
                                         passengerCapacity: 5);

            IVehicle myBike = new Bike();

            IVehicle[] arr = { myCar, myBike };

            foreach(var vehicle in arr)
            {
                Display(vehicle);
            }

            Console.ReadKey();
        }

        static void Display(IVehicle vehicle)
        {
            Console.WriteLine(vehicle.GetInfo());
        }
    }
}
