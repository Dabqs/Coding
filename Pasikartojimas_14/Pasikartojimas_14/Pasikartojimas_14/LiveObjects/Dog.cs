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

        public Dog(string name)
        {
            this.name = name;
        }
        public override string GetRace()
        {
            return "";
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine(" dog " + name);
        }
    }
}
