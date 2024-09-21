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
        int accelerationCoefficient = 0;
        int speed = 4;

        // время, необходимое ковру, чтобы размотаться на старте
        private int readyTime = 0;
        public override int DistanceTraveled => distanceTraveled;
        protected override int Speed => speed;

        protected override int AccelerationCoefficient => accelerationCoefficient;

        public override void Move()
        {
            if (readyTime < 8)
            {
                readyTime++;
            }
            else
            {
                distanceTraveled = speed * timeTraveled + (accelerationCoefficient * timeTraveled * timeTraveled) / 2;
                accelerationCoefficient = (distanceTraveled * distanceTraveled) / 4;
            }
            timeTraveled++;
        }
    }
}
