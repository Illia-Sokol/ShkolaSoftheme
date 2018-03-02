namespace Generics
{
    public class Car
    {
        public string Model { get; set; }

        public override string ToString()
        {
            return string.Format("Car model: {0}", Model);
        }
    }
}