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

        protected int maxTravelTime = 5;
        protected int restDuration = 1;
        protected int speed = 30;

        public override int DistanceTraveled => distanceTraveled;

        protected override int Speed => speed;

        protected override int MaxTravelTime => maxTravelTime;

        protected override int RestDuration => restDuration;

        public override void Move()
        {
            if (timeTraveled < maxTravelTime)
            {
                distanceTraveled += speed;
            }
            else if (timeTraveled >= maxTravelTime + restDuration)
            {
                timeTraveled = 0;
            }
            timeTraveled++;
            //Console.WriteLine($"Дистанция - {distanceTraveled.ToString()} Время{timeTraveled.ToString()}");
            //Console.WriteLine();

        }

    }
}
