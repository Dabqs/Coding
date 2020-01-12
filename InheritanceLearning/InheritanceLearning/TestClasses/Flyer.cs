using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLearning.TestClasses
{
    class Flyer
    {
        private int altitude;
        public Flyer(int altitude)
        {
            this.altitude = altitude;
        }
        public void SetAltitude(int altitude) {
            this.altitude = altitude;
        }
        public void PichUp(int amountOfHeight)
        {
            altitude += amountOfHeight;
        }

    }
}
