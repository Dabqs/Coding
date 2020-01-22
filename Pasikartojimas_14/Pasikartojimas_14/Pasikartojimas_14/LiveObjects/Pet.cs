using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasikartojimas_14.LiveObjects
{
    class Pet : LiveObject, IPrintable
    {

        public override string GetRace()
        {
            return "Pet";
        }

        public virtual void PrintInfo()
        {
            Console.Write("Pet");
        }
    }
}
