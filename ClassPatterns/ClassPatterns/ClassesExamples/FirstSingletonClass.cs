using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPatterns.ClassesExamples
{
     class FirstSingletonClass
    {
        private static FirstSingletonClass single;
        private FirstSingletonClass()
        {

        }
        public static FirstSingletonClass GetInstance()
        {
            if (single == null)
            {
                single = new FirstSingletonClass();
            }
            return single;
        }
    }
}
