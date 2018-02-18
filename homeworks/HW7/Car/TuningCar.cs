using System;

namespace class_1
{
    class TuningCar
    {
        public Car TuningCarColor (string model, int year) {
            return new Car(model, year, "red");
        }
    }
}
