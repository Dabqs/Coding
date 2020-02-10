using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPatterns.ClassesExamples
{
    class Proxy : IStuffDoer
    {
        private readonly RealObject realObject;

        public void DoStuff()
        {
            realObject.DoStuff();
        }
        public Proxy(RealObject realObject)
        {
            this.realObject = realObject;
        }
    }
}
