using System;

namespace class_1
{
    class Car
    {
        public string _model;
        public int _year;
        public string _color; 

        public Car (string model, int year, string color) {
            _model = model;
            _year = year;
            _color = color;
        }

       public void hello(string changeColor) {
        //    _color = changeColor;
           Console.WriteLine(changeColor);
       }

       public void ChangeColor() {
           Console.WriteLine(_year);
       }
    }
}
