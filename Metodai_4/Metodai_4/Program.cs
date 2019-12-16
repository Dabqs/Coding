using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int number = 5;
            Console.WriteLine("Star: " + number);
            IncreaseNormal(number);
            Console.WriteLine("After normal: " + number);
            IncreaseRef(ref number);
            Console.WriteLine("After ref: " + number);
            IncreaseOut(out number);
            Console.WriteLine("After out: " + number);
            //*/
            /*
            int answer = 0;
            if (int.TryParse(Console.ReadLine(),out answer))
            {
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine(answer);
            }
            //*/
            //                                  static int GrazintiSkaiciu(int skaicius) <- in argument
            //                                  static int GrazintiSkaiciu(ref int skaicius) <- in/out argument
            //                                  static int GrazintiSkaiciu(out int skaicius) <- out argument
            /*
            Console.Write("Iveskite savo svori (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite savo ugi (metrais): ");
            double height = Convert.ToDouble(Console.ReadLine());
            double kmi = CalculateKMI(weight, height);
            Console.WriteLine($"Jusu KMI yra {kmi}");
            Console.WriteLine(ValidateKMI(kmi));
            //*/
            /*
            int result = 0;
           result = SumAllNumbers(1, 2, 3);
            Console.WriteLine(result);
            //*/
            /*
            Console.WriteLine("Iveskite pirma skaiciu");
            int firstNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            int secondNo = Convert.ToInt32(Console.ReadLine());

            Sumuoti();
            Atimti();
            Sudauginti();
            Dalinti();
            //*/
            // DarytiKazka(data3:3); // jeigu yra optional, gali vardini priskirti
            /*
            Console.WriteLine("Hello.");
            DarytiKazka();
            Console.WriteLine("Bye.");
            //*/
            /*
            SayHello();
            //*/
        }
        static int IncreaseNormal(int noToIncrease)
        {
            return ++noToIncrease;
        }
        static int IncreaseRef(ref int noToIncrease)
        {
            return ++noToIncrease;
        }
        static int IncreaseOut(out int noToIncrease)
        {
            noToIncrease = 10;
            return noToIncrease;
        }
        static string ValidateKMI(double kmi)
        {
            if (kmi <= 15)
            {
                return "Zmogus badauja";
            }
            else if (kmi <= 18.5)
            {
                return "Zmogus yra liesas";
            }
            else if (18.5 < kmi && kmi <= 25)
            {
                return "Zmogus yra normalus";
            }
            else if (25 < kmi && kmi <= 30)
            {
                return "Zmogus turi virssvorio";
            }
            else if (30 < kmi && kmi <= 40)
            {
                return "Zmogus yra nutukes";
            }
            else
            {
                return "Zmogus yra ligotai nutukes";
            }
        }
        static double CalculateKMI(double weight, double height)
        {
            return weight / (height * height);
        }
        static int SumAllNumbers(int nr1, int nr2, int nr3)
        {
            int result = nr1 + nr2 + nr3;
            return result;
        }

        static void DarytiKazka(int data1 = 0, int data2 = 0, int data3 = 0) // duos defaultine reiksme (kvieciant nebutina integeri duoti. Jeigu duodi, naudos duota reiksme.
                                                                             // jeigu daugiau yra argumentu, optional argumentus rasom nuo galo.
        {
            Console.WriteLine("Do something");
        }
        static void Sumuoti(int firstNo = 5, int secondNo = 2)
        {
            int result = firstNo + secondNo;
            Console.WriteLine($"Skaiciu suma yra {result}.");
        }
        static void Atimti(int firstNo = 5, int secondNo = 2)
        {
            int result = firstNo - secondNo;
            Console.WriteLine($"Skaiciu skirtumas yra {result}.");
        }
        static void Sudauginti(int firstNo = 5, int secondNo = 2)
        {
            int result = firstNo * secondNo;
            Console.WriteLine($"Skaiciu daugyba yra {result}.");
        }
        static void Dalinti(int firstNo = 5, int secondNo = 2)
        {
            double result = (double)firstNo / secondNo;
            Console.WriteLine($"Skaiciu dalmuo yra {result}.");
        }
        static void SayHello()
        {
            Console.WriteLine("Hello.");
            SaySomething();
        }
        static void SaySomething()
        {
            Console.WriteLine("Saying something.");
            SayBye();
        }
        static void SayBye()
        {
            Console.WriteLine("Bye.");
        }

    }
}
