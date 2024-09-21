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
        protected int maxTravelTime = 15;
        protected int restDuration = 4;
        protected int maxSpeed = 15;
        protected int speed = 15;

        public override int DistanceTraveled => distanceTraveled;

        protected override int Speed => speed;

        protected override int MaxTravelTime => maxTravelTime;

        protected override int RestDuration => restDuration;

        public override void Move()
        {
            if (timeTraveled < maxTravelTime)
            {
                distanceTraveled += speed;
                speed -= 1; //скорость уменьшается на каждом тике, затем восстанавливается после отдыха
            }
            else if (timeTraveled >= maxTravelTime + restDuration)
            {
                timeTraveled = 0;
                speed = maxSpeed;
            }
            timeTraveled++;
            //Console.WriteLine($"Дистанция - {distanceTraveled.ToString()} Время{timeTraveled.ToString()}");
            //Console.WriteLine($"Скорость: {speed.ToString()}");
            //Console.WriteLine();

        }
    }
}
