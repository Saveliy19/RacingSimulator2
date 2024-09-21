using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    internal abstract class Vehicle : IMovable
    {

        protected int distanceTraveled;
        protected int timeTraveled;
        protected abstract int Speed { get; }

        public abstract int DistanceTraveled { get; }
        public abstract void Move();
    }
}
