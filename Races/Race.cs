using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Races
{
    internal abstract class Race
    {
        protected int distance;
        protected List<Vehicle> racers = new List<Vehicle>();
        protected Vehicle winner;
        
        // флаг того, что все транспортные средства начали движение
        protected bool isStarted;

        // время гонки
        private int raceTime;

        abstract public int Distance { set; }

        public abstract void AddRacer(Vehicle vehicle);

        public void StartRace()
        {
            Console.WriteLine("На старт. Внимание. Марш!");
            while (winner is null)
            {
                raceTime++;
                foreach (Vehicle racer in racers)
                {
                    if (!isStarted)
                    {
                        Console.WriteLine($"Racer {racer.GetType().Name} started!");
                    }
                    racer.Move();
                    if (racer.DistanceTraveled >= distance)
                    {
                        winner = racer;
                    }
}
                isStarted = true;
            }
            Console.WriteLine($"The winner is {winner.GetType().Name}. Result - {raceTime} ticks");
        }
    }
}
