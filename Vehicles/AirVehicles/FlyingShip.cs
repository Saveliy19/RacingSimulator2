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
        private int _accelerationCoefficient = 0;
        private int _speed = 30;

        Random random = new Random(); //генератор случайных чисел
        private int _previousAccelerationCoefficient;

        public override int DistanceTraveled => distanceTraveled;
        protected override int Speed => _speed;

        protected override int AccelerationCoefficient => _accelerationCoefficient;

        public override void Move()
        {
            if (_accelerationCoefficient == 0)
            {
                distanceTraveled += _speed;
            }
            else
            {
                int averageAcceleration = (_previousAccelerationCoefficient + _accelerationCoefficient) / 2;
                distanceTraveled += _speed + (averageAcceleration) / 2;
            }
            _previousAccelerationCoefficient = _accelerationCoefficient;

            if (random.Next(0, 100) < 50) // 50% шанс попадания в яму
            {
                // ускорение обнуляется
                _accelerationCoefficient = 0;
            }
            else
            {
                _accelerationCoefficient += distanceTraveled;
            }
            //Console.WriteLine($"Ускорение: {accelerationCoefficient.ToString()}");
            
            timeTraveled++;
            //Console.WriteLine($"Дистанция - {distanceTraveled.ToString()} Время {timeTraveled.ToString()}");
            //Console.WriteLine($"Скорость: {speed.ToString()}");
        }
    }
}
