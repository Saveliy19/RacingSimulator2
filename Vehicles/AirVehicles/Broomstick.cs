using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Vehicles.AirVehicles
{
    internal class Broomstick: AirVehicle
    {
        private int _accelerationCoefficient = 0;
        private int _speed = 1;
        public override int DistanceTraveled => distanceTraveled;
        protected override int Speed => _speed;

        protected override int AccelerationCoefficient => _accelerationCoefficient;

        public override void Move()
        {
            distanceTraveled = _speed * timeTraveled + (_accelerationCoefficient * timeTraveled * timeTraveled) / 2;
            timeTraveled++;
            _accelerationCoefficient = distanceTraveled / 2;
        }
    }
}
