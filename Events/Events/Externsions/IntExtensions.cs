using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Externsions
{
    public static class IntExtensions
    {
        public static int PowerTwo(this int number)
        {
            return number * number;
        }
    }
}
