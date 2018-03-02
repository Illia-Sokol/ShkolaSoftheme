namespace Covariance_Interfaces
{
    public class AirplanesFactory : ICovariantVehicleFactory<Airplane>
    {
        public Airplane BuildVehicle()
        {
            return new Airplane { PassangersNumber = 255, Speed = 1200 };
        }

        public Airplane GetVehicle(string type)
        {
            if (type == "cheap")
            {
                return new Airplane { Speed = 250, PassangersNumber = 2 };
            }

            return GetDefaultAirplane();
        }

        public Airplane DefaultVehicle { get { return GetDefaultAirplane(); } }

        private Airplane GetDefaultAirplane()
        {
            return new Airplane { PassangersNumber = 1, Speed = 150 };
        }
    }
}