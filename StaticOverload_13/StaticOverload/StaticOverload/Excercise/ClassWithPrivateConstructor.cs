using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOverload.Excercise
{
    class ClassWithPrivateConstructor
    {
        private ClassWithPrivateConstructor()
        {

        }
        public static void InitiateClass() {
           // ClassWithPrivateConstructor;
        }
    }
}
