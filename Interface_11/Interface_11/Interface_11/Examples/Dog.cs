using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_11.Examples
{
    class Dog : IPrintable, IMoveable
    {
        string name;

        public string InkColor{ get; set; }
        public double Speed { get; set; }

        public void Move()
        {
            Console.WriteLine("Moving at speed " + Speed);
        }

        public void Print()
        {
            Console.WriteLine(name);
        }
    }
}
