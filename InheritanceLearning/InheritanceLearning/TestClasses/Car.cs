using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLearning.TestClasses
{
    class Car : Vehicle
    {
        private bool hasAirbag;
        public Car(bool hasAirbag, int numberOfWheels) :base(numberOfWheels)
        {
            this.hasAirbag = hasAirbag;
            SetNumberOfWheels(numberOfWheels);
            
        }
        public void Drift()
        {
            Console.WriteLine("Wheeew, drifting away.");
        }
    }
}
