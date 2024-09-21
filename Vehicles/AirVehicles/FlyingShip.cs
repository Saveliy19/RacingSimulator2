using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Vehicles.AirVehicles
{
    internal class FlyingShip: AirVehicle
    {
        // + высокая начальная скорость
        // + линейный рост ускорения на каждом шаге
        // - возможно замедление из-за попадания в воздушную яму
        int accelerationCoefficient = 0;
        int speed = 30;

        Random random = new Random(); //генератор случайных чисел
        int previousAccelerationCoefficient;

        public override int DistanceTraveled => distanceTraveled;
        protected override int Speed => speed;

        protected override int AccelerationCoefficient => accelerationCoefficient;

        public override void Move()
        {
            if (accelerationCoefficient == 0)
            {
                distanceTraveled += speed;
            }
            else
            {
                int averageAcceleration = (previousAccelerationCoefficient + accelerationCoefficient) / 2;
                distanceTraveled += speed + (averageAcceleration) / 2;
            }
            previousAccelerationCoefficient = accelerationCoefficient;

            if (random.Next(0, 100) < 50) // 50% шанс попадания в яму
            {
                // ускорение обнуляется
                accelerationCoefficient = 0;
            }
            else
            {
                accelerationCoefficient += distanceTraveled;
            }
            //Console.WriteLine($"Ускорение: {accelerationCoefficient.ToString()}");
            
            timeTraveled++;
            //Console.WriteLine($"Дистанция - {distanceTraveled.ToString()} Время {timeTraveled.ToString()}");
            //Console.WriteLine($"Скорость: {speed.ToString()}");
            
            Console.WriteLine();
        }
    }
}
