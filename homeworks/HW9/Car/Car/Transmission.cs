using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Transmission
    {
        public TransmissionTypes TransmissionType { get; }

        public Transmission(TransmissionTypes transmissionType)
        {
            TransmissionType = transmissionType;
        }
    }

    enum TransmissionTypes
    {
        Automat,
        Mechanical
    }
}
