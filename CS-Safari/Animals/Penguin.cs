using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Safari.Interfaces;

namespace CS_Safari.Animals
{
    public class Penguin : Bird, ISwim, IHunt
    {
        public Penguin(float weight) : base(weight)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Penguin is braying?");
        }

        //public void Hunt()
        //{
        //    Console.WriteLine($"{GetType().Name} is hunting in the water!");
        //}

        public void Swim()
        {
            Console.WriteLine($"{GetType().Name} is swimming!");
        }
    }
}
