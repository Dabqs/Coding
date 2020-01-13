using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasės_8.Test
{
    class Bird : Animal
    {
        private bool canFly;
        protected bool canSwim;
        public int featherCount;


        public Bird(bool canFly, bool canSwim, int featherCount, string color, string name, int age) : base(color,name,age)
        {
            this.canFly = canFly;
            this.canSwim = canSwim;
            this.featherCount = featherCount;
        }

        public bool ShowIfCanFly()
        {
            return canFly;
        }
        public bool ShowIfCanSwim()
        {
            return canSwim;
        }
        public void PrintBird()
        {
            PrintAnimal();
            Console.WriteLine($" Can it fly? {canFly}. Can it swim? {canSwim}. And it has {featherCount} feathers.");
        }
    }
}
