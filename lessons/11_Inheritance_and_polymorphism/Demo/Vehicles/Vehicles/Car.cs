using System;

namespace Vehicles
{
    class Car : Vehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerating");
        }

        public void Brake()
        {
            Console.WriteLine("Braking");
        }

        protected override void DriveInternal()
        {
            Console.WriteLine("Motoring");
        }
    }
}
