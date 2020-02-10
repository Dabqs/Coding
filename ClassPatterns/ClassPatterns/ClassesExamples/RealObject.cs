using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPatterns.ClassesExamples
{
    class RealObject : IStuffDoer
    {
        public void DoStuff()
        {
            Console.WriteLine("Object doing stuff");
        }
    }
}
