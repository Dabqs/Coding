using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLearning.TestClasses
{
    class Gyvunas
    {
        protected int numberOfLegs;
        public string name;
        private int age;
        public Gyvunas(int numberOfLegs, string name, int age)
        {
            this.numberOfLegs = numberOfLegs;
            this.name = name;
            this.age = age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
        public void PrintAnimal()
        {
            Console.WriteLine("Age is: " + age);
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("It has : " + numberOfLegs + " legs.");
        }
    }

}
