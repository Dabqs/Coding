using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLearning.TestClasses
{
    class Airplane : Flyer
    {
        private int liftPower;

        public Airplane(int liftPower, int altitude) : base(altitude)
        {
            this.liftPower = liftPower;
            SetAltitude(altitude);
        }
        public void Land()
        {
            SetAltitude(0);
        }
    }
}
