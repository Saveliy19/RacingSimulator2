using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Vehicles.AirVehicles
{
    internal class Stupa: AirVehicle 
    {
        int accelerationCoefficient = 0;
        int speed = 4;
        protected override int AccelerationCoefficient => accelerationCoefficient;

        public override int DistanceTraveled => distanceTraveled;

        protected override int Speed => speed;

        public override void Move()
        {
            distanceTraveled = speed * timeTraveled + (accelerationCoefficient * timeTraveled * timeTraveled) / 2;
            //Console.WriteLine($"Дистанция ступы - {distanceTraveled.ToString()} Время ступы {timeTraveled.ToString()}");
            //Console.WriteLine();
            accelerationCoefficient = (int)Math.Round(Math.Log10(distanceTraveled));
            timeTraveled++;

        }

    }
}
