using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParser1
{
    class jsonPersonComplex : jsonPerson
    {
        /*
        public string firstname { get; set; }
        public string lastname { get; set; }
        public double age { get; set; }
        public bool isAlive { get; set; }
        public addr address { get; set; }
        */
        public addr address { get; set; }
        public class addr
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public int postCode { get; set; }
        }
    }
}
