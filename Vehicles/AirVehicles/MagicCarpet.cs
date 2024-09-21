using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LR1.Vehicles.AirVehicles
{
    internal class MagicCarpet: AirVehicle
    {
        // - малая начальная скорость
        // - необходимо время на размотку 
        // + квадратичный рост ускорения на каждом шаге
        private int _accelerationCoefficient = 0;
        private int _speed = 4;

        // время, необходимое ковру, чтобы размотаться на старте
        private int _readyTime = 0;
        public override int DistanceTraveled => distanceTraveled;
        protected override int Speed => _speed;

        protected override int AccelerationCoefficient => _accelerationCoefficient;

        public override void Move()
        {
            if (_readyTime < 8)
            {
                _readyTime++;
            }
            else
            {
                distanceTraveled = _speed * timeTraveled + (_accelerationCoefficient * timeTraveled * timeTraveled) / 2;
                _accelerationCoefficient = (distanceTraveled * distanceTraveled) / 4;
            }
            timeTraveled++;
        }
    }
}
