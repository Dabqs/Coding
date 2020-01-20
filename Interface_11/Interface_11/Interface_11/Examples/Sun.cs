using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_11.Examples
{
    class Sun : IPrintable, IGlows
    {
        int brightnessLevel;

        public string InkColor { get; set; }
        public int BrightnessMultiplier { get; set; }
        public void Glow()
        {
            Console.WriteLine("Glowing at brightness" + brightnessLevel * BrightnessMultiplier);        }

        public void Print()
        {
            Console.WriteLine(brightnessLevel);
        }
    }
}
