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
        private int _accelerationCoefficient = 0;
        private int _speed = 4;
        protected override int AccelerationCoefficient => _accelerationCoefficient;

        public override int DistanceTraveled => distanceTraveled;

        protected override int Speed => _speed;

        public override void Move()
        {
            distanceTraveled = _speed * timeTraveled + (_accelerationCoefficient * timeTraveled * timeTraveled) / 2;
            //Console.WriteLine($"Дистанция ступы - {distanceTraveled.ToString()} Время ступы {timeTraveled.ToString()}");
            //Console.WriteLine();
            _accelerationCoefficient = (int)Math.Round(Math.Log10(distanceTraveled));
            timeTraveled++;

        }

    }
}
