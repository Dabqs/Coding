using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasikartojimas_14.LiveObjects
{
   sealed class Worker : Human
    {
        private int salary;
        public Worker(string name, int salary) : base(name)
        {
            this.salary = salary;
        }
        public int GetSalary()
        {
            return salary;
        }
        public override void PrintInfo()
        {
            Console.Write("Worker ");
            base.PrintInfo();
            Console.WriteLine(" $:" + salary);
        }
        public void SetSalary(int salary)
        {
            this.salary = salary;
        }
    }
}
