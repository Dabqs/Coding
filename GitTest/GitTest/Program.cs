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
            Console.WriteLine("Iveskite tris skaicius is eiles (spauskite enter po kiekvieno ivedimo)");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Largest number was {GetLargestNumber(firstNumber,secondNumber,thirdNumber)}.");
        }
        static int GetLargestNumber(int firstNumber,int secondNumber, int thirdNumber) {
            int[] numbers = { firstNumber,secondNumber,thirdNumber};
            int largestNumber = numbers.OrderByDescending(x => x).First();
            return largestNumber;
        }
    }
}
