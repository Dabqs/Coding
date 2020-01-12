using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLearning.TestClasses
{
    class Child : Parent
    {
        private string name;
        public Child(int parentNr, string name) : base(parentNr)
        {
            this.name = name;
            base.name = this.name;
        }

    }
}
