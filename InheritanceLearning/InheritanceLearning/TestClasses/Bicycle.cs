using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLearning.TestClasses
{
    class Bicycle : MovingObject
    {
        private bool hasHelmet;
        public Bicycle(bool hasHelmet, double speed) :base(speed)
        {
            this.hasHelmet = hasHelmet;
            SetSpeed(0);
            
        }
        public void Ride(int speed)
        {
            SetSpeed(speed);
            Console.WriteLine("Started riding the bicycle");
        }
    }
}
