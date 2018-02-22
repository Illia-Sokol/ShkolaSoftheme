using System;

namespace class_1
{
    class TuningCar
    {
        public Car TuningCarColor (Car car, string color) {
            car.ChangeColor(color);
            return car;
        }
    }
}
