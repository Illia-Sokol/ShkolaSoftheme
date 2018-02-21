namespace _05_Extensions
{
    public class Car
    {
        private readonly string _colour;
        private readonly string _model;

        public Car(string model, string colour)
        {
            _colour = colour;
            _model = model;
        }

        public string Colour
        {
            get { return _colour; }
        }

        public string Model
        {
            get { return _model; }
        }
    }
}