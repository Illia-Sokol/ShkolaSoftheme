namespace Interfaces_vehicle
{
    public interface IVehicle
    {
        uint TopSpeed { get; }

        uint PassengerCapacity { get; }

        string GetInfo();
    }
}