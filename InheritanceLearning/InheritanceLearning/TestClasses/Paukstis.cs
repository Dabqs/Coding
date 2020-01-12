using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLearning.TestClasses
{
    class Paukstis : Gyvunas
    {
        private bool canFly;
        protected string breed;
        public string color;
        public Paukstis(bool canFly, string breed, string color, int numberOfLegs, string name, int age) : base(numberOfLegs, name, age)
        {
            this.canFly = canFly;
            this.breed = breed;
            this.color = color;
            base.numberOfLegs = numberOfLegs;
            base.name = name;
            SetAge(age);
        }
        public void PrintBird()
        {
            Console.WriteLine("Can fly: " + canFly);
            Console.WriteLine("Age: " + GetAge());
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Breed: " + breed);
            Console.WriteLine("NumberOfLegs: " + numberOfLegs);
            Console.WriteLine("Name fly: " + name);
        }

    }
}
