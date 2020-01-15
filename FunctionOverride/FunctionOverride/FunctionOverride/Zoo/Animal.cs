using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverride.Zoo
{
    class Animal
    {
        protected string name = "Animal";
        public virtual void Move()
        {
            Console.WriteLine( name + " moves. Using x, y");
        }
        public void Breath()
        {

        }
    }
}
