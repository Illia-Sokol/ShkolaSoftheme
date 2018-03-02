using System;

namespace Covariance_Interfaces
{
    class Program
    {
        // Благодаря ковариантности интерфейсов мы можем присвоить переменной интерфейса параметризированной базовым типом Vehicle
        // интерфейс параметризированный производным типом Airplane (екземпляр класса реализующего интерфейс параметризированный производным типом Airplane),
        // при условии что все возвращаемые значения методов и свойств будут типом который,
        // производный от того типа, который является возвращаемым значением базового интерфейса.
        static void Main(string[] args)
        {
            ICovariantVehicleFactory<Vehicle> baseCovariantInterface = default(ICovariantVehicleFactory<Vehicle>);
            ICovariantVehicleFactory<Airplane> derivedCovariantInterface = default(ICovariantVehicleFactory<Airplane>);
            derivedCovariantInterface = new AirplanesFactory();

            // Covariance: Derived "is a" Base => ICovariantVehicleFactory<Derived> "is a" ICovariantVehicleFactory<Base>.
            baseCovariantInterface = derivedCovariantInterface;

            // So that, when calling baseCovariantInterface.BuildVehicle, the underlying derivedCovariantInterface.BuildVehicle executes.
            // derivedCovariantInterface.BuildVehicle method (Func<Derived>) "is a" baseCovariantInterface.BuildVehicle method (Func<Base>).
            Vehicle vehicle1 = baseCovariantInterface.BuildVehicle();
            Console.WriteLine(vehicle1);

            // When calling baseCovariantInterface.GetVehicle, the underlying derivedCovariantInterface.GetVehicle executes.
            // derivedCovariantInterface.GetVehicle (Func<string, Derived>) "is a" baseCovariantInterface.GetVehicle (Func<string, Base>).
            Vehicle vehicle2 = baseCovariantInterface.GetVehicle("airplane");
            Console.WriteLine(vehicle2);

            // DefaultVehicle property is getter only. The getter is a get_DefaultVehicle method (Func<TResult>).
            // derivedCovariantInterface.DefaultVehicle getter (Func<Derived>) "is a" baseCovariantInterface.DefaultVehicle getter (Func<Base>).
            Vehicle vehicle3 = baseCovariantInterface.DefaultVehicle;
            Console.WriteLine(vehicle3);

            Console.WriteLine(vehicle3.GetType());

            // So, ICovariantVehicleFactory<Airplane> interface "is an" ICovariantVehicleFactory<Vehicle> interface. Above binding always works.
        }
    }
}

