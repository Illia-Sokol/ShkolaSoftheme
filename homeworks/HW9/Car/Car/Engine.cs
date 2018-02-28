using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Engine
    {
        public EngineTypes EngineType { get; }

        public Engine(EngineTypes engine)
        {
            EngineType = engine;
        }
    }

    enum EngineTypes
    {
        Petrol,
        Diesel,
        Gas,
        Oil
    }
}
