using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_11.Examples
{
    class Ghost : IPrintable, IMoveable, IGlows, ISpeaks
    {
        int age;

        public double Decibels { get; set; }
        public int BrightnessMultiplier { get; set; }
        public double Speed { get; set; }
        public string InkColor { get; set; }
        public void Glow()
        {
            Console.WriteLine("Glowing as bright as i can");
        }

        public void Move()
        {
            Console.WriteLine("Moving at speed " + Speed);
        }

        public void Print()
        {
            Console.WriteLine(age);
        }

        public void Speak()
        {
            Console.WriteLine("Boooo, i'm a ghost!");
        }
    }
}
