using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasės_8.Test
{
    class ChiefStudent : Student
    {
        public ChiefStudent(string name, double age, string livingRoom = "Sauletekio al. 6") : base(name, age, livingRoom)
        {
            income = 200;
        }
    }
}
