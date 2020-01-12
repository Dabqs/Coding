using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLearning.TestClasses
{
    class Dog : Animal
    {
        public int spotCount;
        public  void Bark()
        {
            Console.WriteLine("Woof");
            base.happiness += 0.1f;
        }

    }
}
