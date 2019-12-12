using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPrimal(number));
        }
        static bool IsPrimal(int number) {
            bool isPrimal = true;
            /*
            if (number < 2)
            {
                return false;
            }*/

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
