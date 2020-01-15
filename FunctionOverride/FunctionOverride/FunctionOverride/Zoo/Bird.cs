using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverride.Zoo
{
    class Bird : Animal
    {

        public Bird()
        {
            name = "Bird";
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine(name + " and then moves using z" );
        }
        public void Layeggs()
        {

        }
    }
}
