using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasikartojimas_14.LiveObjects
{
    class Human : LiveObject, IPrintable
    {
        protected string Name;

        public override string GetRace()
        {
            return string.Empty;
        }

        public virtual void PrintInfo()
        {
            Console.Write("Human " + Name);
        }

        public Human(string name)
        {
            Name = name;
        }
    }
}
