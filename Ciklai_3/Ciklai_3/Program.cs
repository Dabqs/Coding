using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*=====================================================
            char keyPress = new char();
            int firstDigit = 0;
            int secondDigit = 0;
            double result = 0;
            char[] acceptedSymbols = { '+', '-', '*', '%', '/' };
            do
            {
                Console.WriteLine("Pasirinkite veiksma arba sustabdykite operacija (n arba 0):");
                keyPress = Console.ReadKey(true).KeyChar;
                if (keyPress == 'n' || keyPress == '0' || keyPress == (char)27)
                {
                    break;
                }
                else if (!acceptedSymbols.Any(symbol => symbol == keyPress ))
                {
                    Console.WriteLine($"Veiksmas {keyPress} neatpazintas.");
                    continue;
                }
                Console.WriteLine("Iveskite pirma skaiciu:");
                firstDigit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Iveskite antra skaiciu:");
                secondDigit = Convert.ToInt32(Console.ReadLine());
                switch (keyPress)
                {
                    case '+': result = firstDigit + secondDigit; break;
                    case '-': result = firstDigit - secondDigit; break;
                    case '*': result = firstDigit * secondDigit; break;
                    case '%': result = firstDigit % secondDigit; break;
                    case '/':
                        if (secondDigit == 0)
                        {
                            Console.WriteLine("Dalyba is 0 negalima.");
                            continue;
                        }
                        result = firstDigit / secondDigit;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(result);
            } while (true);
            //*/


            /*=====================================================
            int randomNumber = new Random().Next(0, 100);
            int guess = 0;
            int guessCount = 0;
            bool correctGuess = false;
            Console.WriteLine("Guess a number between 0-100");
            
            do
            {
                ++guessCount;
                guess = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (guess > randomNumber)
                {
                    Console.WriteLine("Guess a smaller number.");
                    continue;
                }
                else if(guess < randomNumber)
                {
                    Console.WriteLine("Guess a larger number.");
                    continue;
                }
                else
                {
                    correctGuess = true;
                    Console.WriteLine($"The number was indeed {guess}! You needed {guessCount} times to get it right.");
                }
            } while (!correctGuess);
            //*/
            /*=====================================================
            Console.WriteLine("How many Fibonacci numbers do you want to see printed?");
            int itterations = Convert.ToInt32(Console.ReadLine());
            int lastFibonacci = 1;
            int previousToLastFibonacci = 0;
            int fibonacciNumber = 0;
            if (itterations > 0)
            {
                for (int i = 0; i < itterations; i++)
                {
                    switch (i)
                    {
                        case 0:
                            fibonacciNumber = 0;
                            break;
                        case 1:
                            fibonacciNumber = 1;
                            break;
                        default:
                            fibonacciNumber = previousToLastFibonacci + lastFibonacci;
                            previousToLastFibonacci = lastFibonacci;
                            lastFibonacci = fibonacciNumber;
                            break;
                    }
                    Console.WriteLine(fibonacciNumber);
                }
            }
        }
        //*/

            /*=====================================================
            int sum = 0;
            //for (int i = 0; i < 1000; i++)
            int i = 0;
            for (; ; )
            {
                if (i < 1000)
                {
                    if (i > 123)
                    {
                        break;
                    }
                    i++;
                    if (i != 0 && i % 5 == 0)
                    {
                        continue;
                    }
                    sum += i;
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine(sum);
            //*/
            /*=====================================================
            const int maxWindowSeats = 4;
            const int planeCapacity = 8;
            int takenWindowSeats = 0;
            int totalTakenSeats = 0;
            do
            {
                Console.WriteLine("Do you want to sit near window?");
                string answer = Console.ReadLine();
                switch (answer.ToLower())
                {
                    case "taip":
                    case "t":
                    case "1":
                        takenWindowSeats++;
                        totalTakenSeats++;
                        break;
                    case "ne":
                    case "n":
                    case "0":
                        totalTakenSeats++;
                        break;
                    default:
                        Console.WriteLine("Nesupratau jusu ataskymo. Pasirinkite taip, ne, t, n, 1 arba 0.");
                        break;
                }
            } while (takenWindowSeats < maxWindowSeats && totalTakenSeats < planeCapacity);

            //*/

            /*=====================================================
             string produktas = string.Empty;
             int pasirinkimas =0;
             while (pasirinkimas < 1 || pasirinkimas > 3)
             {
                 Console.Clear();
                 Console.WriteLine("Pasirinkite:\n" +
                "1 - Kava\n" +
                "2 - Arbata\n" +
                "3 - Vanduo\n");
                 pasirinkimas = Convert.ToInt32(Console.ReadLine());
             }
             switch (pasirinkimas)
             {
                 case 1:
                     produktas = "kava";
                     break;
                 case 2:
                     produktas = "arbata";
                     break;
                 case 3:
                     produktas = "vandeni";
                     break;
                 default:
                     break;
             }
             Console.WriteLine($"Jus pasirinkote {produktas}.");
             //*/

            /*=====================================================
            int result = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        //*/

            /*=====================================================
            startas:
                Console.WriteLine("Insert first number:");
                int beginning = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert second number:");
                int end = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (beginning < end)
                {
                    for (; beginning <= end; beginning++) //nieko nedarau su beginning, del to jo pradzioje net nereikia ir naudoti.
                    {
                        Console.WriteLine(beginning);
                    }
                }
                else
                {
                    Console.WriteLine("Your first number is larger than the second one. Please make first number bigger.");
                    goto startas;
                }
                //*/
            /*
            for (int i = 0; i < 20; i += 3)
            {
                Console.WriteLine(i);
            }//*/
        }
    }
}



