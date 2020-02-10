using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPatterns.ClassesExamples
{
    class MyCommand : Command
    {
        public override void Execute()
        {
            Console.WriteLine("Execute my logic");
        }
    }
}
