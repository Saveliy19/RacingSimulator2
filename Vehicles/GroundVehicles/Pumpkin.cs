using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Vehicles.GroundVehicles
{
    internal class Pumpkin: GroundVehicle
    {
        // + высокая начальная скорость
        // - скорость уменьшается на каждом тике
        private int _maxTravelTime = 15;
        private int _restDuration = 4;
        private int _maxSpeed = 15;
        private int _speed = 15;

        public override int DistanceTraveled => distanceTraveled;

        protected override int Speed => _speed;

        protected override int MaxTravelTime => _maxTravelTime;

        protected override int RestDuration => _restDuration;

        public override void Move()
        {
            if (timeTraveled < _maxTravelTime)
            {
                distanceTraveled += _speed;
                _speed -= 1; //скорость уменьшается на каждом тике, затем восстанавливается после отдыха
            }
            else if (timeTraveled >= _maxTravelTime + _restDuration)
            {
                timeTraveled = 0;
                _speed = _maxSpeed;
            }
            timeTraveled++;
            //Console.WriteLine($"Дистанция - {distanceTraveled.ToString()} Время{timeTraveled.ToString()}");
            //Console.WriteLine($"Скорость: {speed.ToString()}");
            //Console.WriteLine();

        }
    }
}
