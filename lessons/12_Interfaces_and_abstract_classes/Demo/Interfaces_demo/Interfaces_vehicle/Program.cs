using System;

namespace Interfaces_vehicle
{
    class Program
    {
        static void Main()
        {
            IVehicle myVehicle = new Car(wheels: 4,
                                         topSpeed: 200,
                                         passengerCapacity: 5);

            var info = myVehicle.GetInfo();

            Console.WriteLine(info);

            Console.ReadKey();
        }
    }
}
