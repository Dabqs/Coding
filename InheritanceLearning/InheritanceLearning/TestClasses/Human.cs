using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLearning.TestClasses
{
    class Human : MovingObject
    {
        private int age;
        public Human(int age, double speed) : base(speed)
        {
            this.age = age;
            SetSpeed(speed);
        }
        public void Talk()
        {
            Console.WriteLine("What... I'm talking to you.");
        }
    }
}
