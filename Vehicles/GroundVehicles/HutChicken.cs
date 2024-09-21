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
        protected int maxTravelTime = 100;
        protected int restDuration = 10;
        protected int speed = 10;

        // время, необходимое избе, чтобы встать после начала гонки
        private int riseTime = 0;

        protected override int RestDuration => restDuration;
        protected override int MaxTravelTime => maxTravelTime;
        protected override int Speed => speed;

        public override int DistanceTraveled => distanceTraveled;
        public override void Move()
        {
            if (riseTime < 5)
            {
                riseTime++;
            }
            else
            {
                if (timeTraveled < maxTravelTime)
                {
                    distanceTraveled += speed;
                }
                else if (timeTraveled >= maxTravelTime + restDuration)
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
