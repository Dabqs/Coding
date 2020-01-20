using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_11.Examples
{
    interface IRendetable
    {
        string InitStatement { get; set; }
        void Render();
    }
}
