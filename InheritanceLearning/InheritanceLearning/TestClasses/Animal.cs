using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLearning.TestClasses
{
    class Animal
    {
        public string name;
        public int age;
        public float happiness;
        public void PrintBase()
        {
            Console.WriteLine("name" + name);
            Console.WriteLine("age" + age);
            Console.WriteLine("happiness" + happiness);
        }
    }
}
