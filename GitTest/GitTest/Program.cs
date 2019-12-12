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
            Console.WriteLine($"It is {InRange(firstNumber, secondNumber, thirdNumber)} that first number is in the middle of other two.");
        }
        static int GetLargestNumber(int firstNumber,int secondNumber, int thirdNumber) {
            int[] numbers = { firstNumber,secondNumber,thirdNumber};
            int largestNumber = numbers.OrderByDescending(x => x).First();
            return largestNumber;
        }
        static bool InRange(int firstNumber, int secondNumber, int thirdNumber)
        {
            bool firstNumberIsWithinRange = false;
            int[] numbers = { firstNumber, secondNumber, thirdNumber };
            int middleNumber = numbers.OrderByDescending(x => x).ToArray()[1];
            if (middleNumber == firstNumber)
            {
                firstNumberIsWithinRange = true;
            }
            return firstNumberIsWithinRange;
        }
    }
}
