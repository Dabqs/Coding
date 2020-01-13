using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasės_8.Test
{
    class Animal
    {
        private string color;
        public string name;
        protected int age;

        public Animal(string color, string name, int age)
        {
            this.color = color;
            this.name = name;
            this.age = age;
        }
        public int GetAnimalAge()
        {
            return age;
        }
        public string GetAnimalColor()
        {
            return color;
        }

        public void PrintAnimal()
        {
            Console.Write($"This animal has name {name}. It is {color} and is {age} years old.");
        }
    }
}
