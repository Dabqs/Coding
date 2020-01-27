using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces.MyLibrary
{
    class Enemy : Unit
    {
        private readonly string name;
        public Enemy()
        {
            name = "Neimas is MyLibrary";
        }

        public override void DoStuff()
        {
            base.DoStuff();
        }
        public void PrintName()
        {
            Console.WriteLine("Name is: " + name);
        }
    }
}
