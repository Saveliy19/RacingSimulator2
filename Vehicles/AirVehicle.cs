using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Vehicles
{
    internal abstract class AirVehicle: Vehicle
    {
        protected abstract int AccelerationCoefficient { get; }
    }
}
