using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOverload.Excercise
{
    class AllStatic
    {
        public static int MinNumber { get; set; } = 0;
        private static int MaxNumber { get; set; } = 50;

        public  AllStatic(int minNumber, int maxNumber)
        {
            MinNumber = minNumber;
            MaxNumber = maxNumber;
        }

        public static void Show()
        {
            PrintValues();
        }
        private static void PrintValues()
        {
            Console.WriteLine(MinNumber);
            Console.WriteLine(MaxNumber);
        }
    }
}
