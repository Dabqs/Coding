using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_7
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numberPile = new List<int>() { 0,1,2,3,4,5,6,7,8,9};

            numberPile.ForEach(PrintNumbers);
            PrintMyNumberList("Before remove: ", numberPile);

            numberPile.RemoveAll(TestNumberEven);
            PrintMyNumberList("After remove: ", numberPile);
            numberPile.ForEach(PrintNumbers);
            numberPile.RemoveAll(TestNumberOdd);

            numberPile.ForEach(PrintNumbers);


            PrintMyNumberList("After remove: ",numberPile);

            Console.WriteLine(numberPile.Contains(2));
            Console.WriteLine(numberPile.IndexOf(2));

            int numberThreeIndex = numberPile.IndexOf(2);

            if (numberThreeIndex == -1)
            {
                Console.WriteLine("Neradau");
            }
            else
            {
                Console.WriteLine("Radau." + numberThreeIndex);
            }

            Console.WriteLine(numberPile.Find(TestNumberEven));
            Console.WriteLine(numberPile.FindAll(TestNumberEven));
            PrintMyNumberList("Find all odd: ",numberPile.FindAll(TestNumberEven));

            Console.WriteLine(numberPile.Exists(TestNumberOdd));

            List<int> numbers = new List<int>();
            List<char> symbols = new List<char>();
            List<string> textPile = new List<string>() { "string1","String2"};
            List<bool> booleans = new List<bool>();

            textPile.Add("string3");
            textPile.Insert(1, "string4");

            textPile.AddRange(new string[] { "string5","string6"});
            textPile.AddRange(new List<string> { "string7","string8"});
            textPile.InsertRange(1, new string[] { "string9" });

            for (int i = 0; i < textPile.Count; i++)
            {
                Console.WriteLine(textPile[i]);
            }

            foreach (string item in textPile)
            {
                Console.WriteLine(item);
            }

            textPile.Remove("string9");
            textPile.RemoveAt(4);
            textPile.RemoveRange(1, 2);
            

            textPile.ForEach(PrintText); //wow!

        }
        static void PrintText(string item)
        {
            Console.Write(item + ", ");
        }
        static void PrintNumbers(int item)
        {
            Console.Write(item + ", ");
        }
        static bool TestNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }
        static bool TestNumberOdd(int number)
        {
            if (number % 2 != 0)
            {
                return true;
            }
            return false;
        }
        static void PrintMyNumberList(string message,List<int> numberPile)
        {
            Console.Write(message + $"[{numberPile.Count}]");
            numberPile.ForEach(PrintNumbers);
            Console.WriteLine();
        }
    }
}
