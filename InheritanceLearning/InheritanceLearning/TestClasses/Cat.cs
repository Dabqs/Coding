using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLearning.TestClasses
{
    class Cat: Animal
    {
        public float cuteness;
        public void Meow()
        {
            Console.WriteLine("Meow");
        }
    }
}
