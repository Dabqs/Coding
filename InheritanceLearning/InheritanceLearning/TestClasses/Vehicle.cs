using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLearning.TestClasses
{
    class Vehicle : MovingObject
    {
        private int wheelCout;

        public Vehicle(int numberOfWheels, double speed) : base(speed)
        {
            wheelCout = numberOfWheels;
            SetSpeed(speed);
        }
        public void SetNumberOfWheels(int numberOfWheels)
        {
            this.wheelCout = numberOfWheels;
        }
        public void ChangeWheel()
        {
            Console.WriteLine($"Currentyl the vehicle has {wheelCout} wheels. Removing one, because the one needs to be changed.");
            wheelCout--;
            Console.WriteLine($"Now the vehicle has only {wheelCout} wheels. Putting on a new one.");
            wheelCout++;
            Console.WriteLine($"The wheel has been changed. You can find {wheelCout} wheels on the vehicle again.");
        }
    }
}
