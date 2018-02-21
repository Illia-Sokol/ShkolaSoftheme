using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_vehicle
{
    class Bike : IVehicle
    {
        public uint TopSpeed => 50;
        public uint PassengerCapacity => 1;

        public string GetInfo()
        {
            var info = string.Format("Vehicle type: 'Bike', top speed: '{0}'", TopSpeed);
            return info;
        }
    }
}
