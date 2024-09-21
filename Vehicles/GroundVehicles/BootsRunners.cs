using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Vehicles.GroundVehicles
{
    internal class BootsRunners: GroundVehicle
    {
        // + высокая скорость
        // + средняя выносливость
        // + быстрое восстановление

        private int _maxTravelTime = 5;
        private int _restDuration = 1;
        private int _speed = 30;

        public override int DistanceTraveled => distanceTraveled;

        protected override int Speed => _speed;

        protected override int MaxTravelTime => _maxTravelTime;

        protected override int RestDuration => _restDuration;

        public override void Move()
        {
            if (timeTraveled < _maxTravelTime)
            {
                distanceTraveled += _speed;
            }
            else if (timeTraveled >= _maxTravelTime + _restDuration)
            {
                timeTraveled = 0;
            }
            timeTraveled++;
            //Console.WriteLine($"Дистанция - {distanceTraveled.ToString()} Время{timeTraveled.ToString()}");
            //Console.WriteLine();

        }

    }
}
