using LR1.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Races
{
    internal class GroundRace: Race
    {
        public override void AddRacer(Vehicle vehicle)
        {
            if (!(vehicle is GroundVehicle))
            {
                throw new InvalidOperationException("В наземной гонке не могут участвовать воздушные транспортные средства!");
            }
            else racers.Add(vehicle);
        }

        public override int Distance { set { distance = value; } }
    }
}
