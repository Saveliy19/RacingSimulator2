using LR1.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Races
{
    internal class AirRace: Race
    {
        public override void AddRacer(Vehicle vehicle)
        {
            if (!(vehicle is AirVehicle))
            {
                throw new InvalidOperationException("В воздушной гонке не могут участвовать наземные транспортные средства!");
            }
            else racers.Add(vehicle);
        }

        public override int Distance { set { distance = value; } }
    }
}
