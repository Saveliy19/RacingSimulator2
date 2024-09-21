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
        protected Vehicle? winner;
        
        // флаг того, что все транспортные средства начали движение
        protected bool isStarted;


        // время гонки
        protected int raceTime;

        abstract public int Distance { set; }

        public abstract void AddRacer(Vehicle vehicle);

        public void StartRace()
        {
            List<Vehicle> finishedRacers = new List<Vehicle>();
            int bestResult = 0;
            Console.WriteLine("На старт. Внимание. Марш!");
            while (finishedRacers.Count < racers.Count)
            {
                raceTime++;
                foreach (Vehicle racer in racers)
                {
                    if (!isStarted)
                    {
                        Console.WriteLine($"Racer {racer.GetType().Name} started!");
                    }

                    if (racer.DistanceTraveled < distance)
                    {
                        racer.Move();
                    }
                    else
                    {
                        if (winner is null)
                        {
                            winner = racer;
                            bestResult = raceTime;
                            Console.WriteLine();
                            Console.WriteLine($"{racer.GetType().Name} FINISHED! Result - {raceTime} ticks");
                            finishedRacers.Add(racer);

                        }
                        else if (!finishedRacers.Contains(racer))
                        {
                            Console.WriteLine($"{racer.GetType().Name} FINISHED! Result - {raceTime} ticks");
                            finishedRacers.Add(racer);
                        }
                    }
                    
}
                isStarted = true;

            }
            Console.WriteLine();
            Console.WriteLine($"The winner is {winner.GetType().Name}. Result - {bestResult} ticks");
        }
    }
}
