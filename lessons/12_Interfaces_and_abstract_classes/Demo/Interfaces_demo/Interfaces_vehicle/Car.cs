namespace Interfaces_vehicle
{
    public class Car : IVehicle
    {
        public Car(uint wheels, uint topSpeed, uint passengerCapacity)
        {
            Wheels = wheels;
            PassengerCapacity = passengerCapacity;
            TopSpeed = topSpeed;
        }

        public uint Wheels { get; private set; }

        public uint TopSpeed { get; private set; }

        public uint PassengerCapacity { get; private set; }

        public string GetInfo()
        {
            var info = string.Format("Vehicle type: 'Car', top speed: '{0}'", TopSpeed);
            return info;
        }
    }
}