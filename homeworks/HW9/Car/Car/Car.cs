using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    struct Car
    {
        public Engine Engine { get; private set;  }
        public Color Color { get; private set; }
        public Transmission Transmission { get; private set; }

        public Car(Engine engine, Color color, Transmission transmission)
        {
            Engine = engine;
            Color = color;
            Transmission = transmission;
        }

        public void ChangeEngine(Engine engine)
        {
            Engine = engine;
        }
    }
}
