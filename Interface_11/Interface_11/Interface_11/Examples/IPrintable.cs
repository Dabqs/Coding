using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_11.Examples
{
    interface IPrintable
    {
        string InkColor { get; set; }
        void Print();
    }
}
