using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOverload.Overloading
{
    class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public bool CanFly { get; set; }
        public string Breed { get; set; }

        public Animal(int age, string name, string breed)
        {
            Age = age;
            Name = name;
            CanFly = DetermineWhetherCanFly();
            Breed = breed;
        }
        public Animal(int age, string name, bool canFly)
        {
            Age = age;
            Name = name;
            CanFly = canFly;

            Breed = canFly? "Bird":"Unknown";
        }
        public bool DetermineWhetherCanFly(bool canFly)
        {
            return canFly ? true : false;
        }
        public bool DetermineWhetherCanFly()
        {
            bool result = false;
            Console.WriteLine("Press Y if it can fly or N if it cant");
            if (Console.ReadLine() == "y")
            {
                return true;
            }
            else if (Console.ReadLine() == "n")
            {
            }
            else
            {
                Console.WriteLine("Didn't get the answer");
            }
            return false;

        }


    }

}
