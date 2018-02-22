using System;

namespace class_1
{
    class Car
    {
        public string Model {get; }
        public int Year { get; }
        public string Color { get; private set; }

        public Car (string model, int year, string color) {
            Model = model;
            Year = year;
            Color = color;
        }

       public void ChangeColor(string color) {
            Color = color;
       }
    }
}
