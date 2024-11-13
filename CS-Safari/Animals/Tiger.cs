using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Safari.Interfaces;

namespace CS_Safari.Animals
{
    public class Tiger : PantheraBigCat, IHunt
    {
        public Tiger(float weight) : base(weight)
        {
        }

        //public void Hunt()
        //{
        //    Console.WriteLine($"{GetType().Name} is hunting on land!");

        //}

    }
}
