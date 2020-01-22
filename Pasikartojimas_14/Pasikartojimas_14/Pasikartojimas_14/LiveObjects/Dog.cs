using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasikartojimas_14.LiveObjects
{
    class Dog : Pet
    {
        private string name;

        public Dog(string name) :base()
        {
            this.name = name;
        }
        public override string GetRace()
        {
            return "Dog";
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine(" " + this.GetRace() + " " + name);
        }
    }
}
