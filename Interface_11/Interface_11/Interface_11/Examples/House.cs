using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_11.Examples
{
    class House : IPrintable
    {
        string type;

        public string InkColor { get; set; }
        public void Print()
        {
            Console.WriteLine("Type");
        }
    }

}
