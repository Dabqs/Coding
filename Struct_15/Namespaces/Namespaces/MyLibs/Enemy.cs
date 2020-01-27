using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces.MyLibs
{
    class Enemy : IEnamy
    {
        private string name;

        public Enemy()
        {
            name = "Neimas is MyLibs";
        }
        public void DoStuff()
        {
            Console.WriteLine("Yeah, i'm doing stuff alright.");
        }
        public string Name { get {
                return name;
            } set { } }
    }
}
