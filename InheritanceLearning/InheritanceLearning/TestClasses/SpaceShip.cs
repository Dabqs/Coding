using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLearning.TestClasses
{
    class SpaceShip : MovingObject
    {
        private float oxygenAmount;
        
        public SpaceShip(float oxygenAmount, int speed) : base(speed)
        {
            this.oxygenAmount = oxygenAmount;
            SetSpeed(speed);
        }
        public void StartHyperDrive()
        {
            Console.WriteLine("Hyperdrive initiated.");
            SetSpeed(60000);
        }
    }
}
