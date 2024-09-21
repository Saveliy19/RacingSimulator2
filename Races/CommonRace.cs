using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Races
{
    internal class CommonRace : Race
    {
        public override void AddRacer(Vehicle vehicle)
        {
            racers.Add(vehicle);
        }

        public override int Distance { set { distance = value; } }

    }
}
