using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/*
 {
 "firstname" : "Roger",
 "lastname" : "Moore",
 "age" : 89,
 "isAlive" : false
 }
  */

namespace JSONParser1
{
    class jsonPerson
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public double age { get; set; }
        public bool isAlive { get; set; }
    }
}
