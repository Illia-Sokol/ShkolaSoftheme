namespace Covariance_Interfaces
{
    public interface ICovariantVehicleFactory<out TResult>
               where TResult : Vehicle   // TResult is covariant for all members of interface.
    {
        TResult BuildVehicle();

        TResult GetVehicle(string type);

        TResult DefaultVehicle { get; }
    }
}