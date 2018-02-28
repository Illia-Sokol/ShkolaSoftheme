using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class CarConstructor
    {
        public Car Construct(Engine engine, Color color, Transmission transmission)
        {
            return new Car(engine, color, transmission);
        }

        public Car Reconstruct(Car car, Engine engine)
        {
            car.ChangeEngine(engine);
            return car;
        }
    }
}
