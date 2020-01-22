using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasikartojimas_14.LiveObjects
{
   sealed class Client : Human
    {
        private static int clientCount = 0;

        public Client(string name) : base(name)
        {
        }
        public override void PrintInfo()
        {
            Console.Write("Client ");
            base.PrintInfo();
            Console.WriteLine(" id:" + ClientId);
        }
        public int ClientId { get; set; }
    }
}
