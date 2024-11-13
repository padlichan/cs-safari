using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Safari
{
    public abstract class Animal
    {
        public float Weight { get; set; }

        protected Animal(float weight)
        {
            Weight = weight;
        }

        public abstract void MakeSound();
    }
}
