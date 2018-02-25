using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Car
    {
        public Engine Engine { get; private set;  }
        public Color Color { get;  }
        public Transmission Transmission { get;  }

        public Car(Engine engine, Color color, Transmission transmission)
        {
            Console.WriteLine("Create Car");
        }

        public void ChangeEngine(Engine engine)
        {
            Engine = engine;
        }
    }
}
