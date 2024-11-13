using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Safari
{
    public abstract class Bird : Animal
    {
        protected Bird(float weight) : base(weight)
        {
        }

        public override void MakeSound()
        {

        }
    }
}
