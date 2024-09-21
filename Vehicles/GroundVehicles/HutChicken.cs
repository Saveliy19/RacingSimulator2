using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Vehicles.GroundVehicles
{
    internal class HutChicken: GroundVehicle
    {
        // + может долго бежать
        // + средняя скорость
        // - долгое восстановление
        // - нужно время, чтобы встать
        private int _maxTravelTime = 100;
        private int _restDuration = 10;
        private int _speed = 10;

        // время, необходимое избе, чтобы встать после начала гонки
        private int riseTime = 0;

        protected override int RestDuration => _restDuration;
        protected override int MaxTravelTime => _maxTravelTime;
        protected override int Speed => _speed;

        public override int DistanceTraveled => distanceTraveled;
        public override void Move()
        {
            if (riseTime < 5)
            {
                riseTime++;
            }
            else
            {
                if (timeTraveled < _maxTravelTime)
                {
                    distanceTraveled += _speed;
                }
                else if (timeTraveled >= _maxTravelTime + _restDuration)
                {
                    timeTraveled = 0;
                }
            }
            timeTraveled++;
            //Console.WriteLine($"Дистанция - {distanceTraveled.ToString()} Время {timeTraveled.ToString()}");
            //Console.WriteLine();
        }
    }
}
