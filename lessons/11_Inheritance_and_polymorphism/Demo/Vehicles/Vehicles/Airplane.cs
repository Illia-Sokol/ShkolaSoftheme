using System;

namespace Vehicles
{
    class Airplane : Vehicle
    {
        public void TakeOff()
        {
            Console.WriteLine("Taking off");
        }

        public void Land()
        {
            Console.WriteLine("Landing");
        }

        protected override void DriveInternal()
        {
            Console.WriteLine("Flying");            
        }
    }
}
