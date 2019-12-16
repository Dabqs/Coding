using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Kintamieji
    {
        public static void kintamujuPaskaitai()
        {

            int kintamasisTestui = 50;
            Console.WriteLine($"Sukūriau kintamąjį {kintamasisTestui.GetType()}, kurio:\n" +
                $"Reikšmė yra {kintamasisTestui}\n" +
                $"Dydis {sizeof(int)} baitai \n" +
                $"Minimali reikšmė yra {int.MinValue}\n" +
                $"Maksimali reikšmė yra {int.MaxValue}");
            Console.ReadLine();
            int ba = 50;
            Console.WriteLine(Convert.ReferenceEquals(kintamasisTestui, ba));
            int a = 10;
            int b = 12;
            Console.WriteLine($"Integer a is {a}, integer b is {b}");
            //tuples method. Requires at least .net 4.6.1
            (a, b) = (b, a);
            Console.WriteLine($"Integer a is {a}, integer b is {b}");

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            //*
            double threshold = 12.5;
            int temperature = -100;
            char theFirstChar = 'a';
            string assignmentName = "uzduotis";
            bool isThisTrue = false;

            //Geras tipsas rasymui
            Console.WriteLine($"Threshold is {threshold}, and the string was {assignmentName}");
            //*/

        }


    }
}
