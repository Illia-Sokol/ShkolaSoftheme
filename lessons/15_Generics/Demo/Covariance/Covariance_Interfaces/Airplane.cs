namespace Covariance_Interfaces
{
    public class Airplane : Vehicle
    {
        public uint PassangersNumber { get; set; }

        public uint Speed { get; set; }

        public override string ToString()
        {
            return "I am derived";
        }
    }
}