using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasės_8.Test
{
    class Person
    {
        private string name = "NoName";
        private double age;
        protected int income;

        public Person(string name, double age)
        {
            this.name = name;
            this.age = age;
            income = 0;
        }
        public void ChangeName(string newName)
        {
            name = newName;
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"My name is {name} and i am {age}. I earn {income}.");
        }
    }

}
