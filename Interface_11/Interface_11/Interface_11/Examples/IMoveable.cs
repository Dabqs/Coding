using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_11.Examples
{
    interface IMoveable
    {
        double Speed { get; set; }
        void Move();
    }
}
