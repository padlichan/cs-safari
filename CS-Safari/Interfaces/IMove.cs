using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Safari.Interfaces
{
    [Obsolete("This interface is obsolete. Use IFly, IHunt, and ISwim instead.", true)]
    internal interface IMove
    {
        void Move();
    }
}
