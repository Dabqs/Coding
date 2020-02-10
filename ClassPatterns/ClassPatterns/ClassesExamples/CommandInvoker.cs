using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPatterns.ClassesExamples
{
    class CommandInvoker
    {
        public CommandInvoker()
        {

        }
        public void ExecuteCommand<T>() where T : Command, new() {
            T command = new T();
            command.Execute();
        }
    }
}
