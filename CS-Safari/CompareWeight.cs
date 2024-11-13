using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Safari
{
    public class CompareWeight : IComparer<Animal>
    {
        private bool isAscending;
        public CompareWeight(bool isAscending)
        {
            this.isAscending = isAscending;
        }
        public int Compare(Animal animal1, Animal animal2)
            {
            if (isAscending)
            {
                if (animal1.Weight > animal2.Weight) return 1;
                else if (animal1.Weight < animal2.Weight) return -1;
                return 0;
            }
            else
            {
                //Same as above but swap the argumants in the comparison
                if (animal2.Weight > animal1.Weight) return 1;
                else if (animal2.Weight < animal1.Weight) return -1;
                return 0;
            }
            
            }
     
    }
}
