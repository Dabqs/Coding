using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOverload.Utils
{
    static class PrintUtil
    {

        public static void Print(IEnumerable<int> data, string message)
        {
            Console.WriteLine(message);
            foreach (int item in data)
            {
                Console.Write(item);
                Console.Write(", ");
            }
        }
        /*
        public static void Print(List<int> data, string message)
        {
            Console.WriteLine(message);
            foreach (int item in data)
            {
                Console.Write(item);
                Console.Write(", ");
            }
        }
        public static void Print(int[] data, string message)
        {
            Console.WriteLine(message);
            foreach (int item in data)
            {
                Console.Write(item);
                Console.Write(", ");
            }
        }
        //*/
    }
}
