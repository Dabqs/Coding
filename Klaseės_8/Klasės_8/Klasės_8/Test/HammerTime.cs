using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasės_8.Test
{
   class HammerTime
    {
        private double Length;
        private int hitCount;

        public HammerTime(double Length)
        {
            this.Length = Length;
            hitCount = 0;
        }
        public void HitNail()
        {
            hitCount++;
        }
        public int GetHitCount()
        {
            return hitCount;
        }
        public void SetLenght(int length)
        {
            Length = length;
        }
        public double GetLenght()
        {
            return Length;
        }

    }
}
