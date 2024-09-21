using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Vehicles
{
    internal abstract class GroundVehicle: Vehicle
    {
        protected abstract int MaxTravelTime { get; }
        protected abstract int RestDuration { get; }
    }
}
