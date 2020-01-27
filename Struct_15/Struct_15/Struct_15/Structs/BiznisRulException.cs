using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_15.Structs
{
    class BiznisRulException : Exception
    {
        public BiznisRulException(string errorMsg) : base("BiznisRulException: " + errorMsg) { }

    }
}
