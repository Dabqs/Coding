using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsontESTING
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> jsonArray = JsonConvert.DeserializeObject<List<string>>(@"[""first"",""second""]");
            foreach (string str in jsonArray)
            {
                Console.WriteLine(str);
            }
        }
    }
}
