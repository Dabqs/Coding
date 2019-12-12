using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPrimal(number));

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(D20());
            }

        }
        static bool IsPrimal(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int D20()
        {
            return random.Next(1, 20);
        }
    }
}
