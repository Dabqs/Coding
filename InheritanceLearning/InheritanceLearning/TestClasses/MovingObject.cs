using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLearning.TestClasses
{
    class MovingObject
    {
        private double speed;
        public MovingObject(double speed)
        {
            this.speed = speed;
        }
        public void SetSpeed(double speed)
        {
            this.speed = speed;
        }
        public void Move(double speed)
        {
            if (this.speed == 0)
            {
                this.speed += speed;
            }
            else
            {
                Console.WriteLine("It's already moving.");
            }
        }
    }
}
