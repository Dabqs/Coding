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
            #region Užduotis
            /*
            string wordToFind = "laboratorijoje";
            string textBlock = @"Virtualios realybės laboratorijoje dr. Tomas Blažauskas (KTU Informatikos fakulteto dėstytojas) padėjo pasitikrinti savo žinias apie virtualiąją realybę – vienu iš šiuo metu plačiausiai vystomu technologiniu objektu, sužinoti, kaip kuriamos simuliacijos ir išbandyti KTU studentų kuriamus VR projektus.
 Dalyvavo ekskursijoje po „Teltoniką“ (inovatyvią ir jaunatvišką įmonę, užsiimančią daiktų interneto sprendimais). Apsilankė potencialioje darbovietėje, kur susipažino su ten dirbančiomis moterimis, sužinojo, kokias užduotis jos atlieka darbo vietoje ir kokių įgūdžių joms reikia norint dirbti IT sferoje.";
            textBlock = RemoveNonLetters(textBlock);
            List<string> listOfWords = textBlock.Split(' ').ToList();
            int longestWordLength = listOfWords.OrderByDescending(x => x.Length).First().Length;
            Console.WriteLine(longestWordLength);
            Console.WriteLine(string.Join(Environment.NewLine, listOfWords.Where(x => x.Length == longestWordLength)));
            Console.WriteLine($"List contains {listOfWords.Count} words.");
            Console.WriteLine($"It is {listOfWords.Exists(x => x == "laboratorijoje")} that list contains word '{wordToFind}'.");
            List<string> shuffledList = listOfWords.OrderBy(x => Guid.NewGuid()).ToList();
            Console.WriteLine();
            Random rnd = new Random();
            for (int i = rnd.Next(3, 12); i < shuffledList.Count; i = i + rnd.Next(3,12))
            {
                shuffledList[i] = shuffledList[i] + ".";
            }
            if (!shuffledList.Last().EndsWith("."))
            {
                shuffledList.Add(".");
            }
            shuffledList.ForEach(PrintAllStrings);
            Console.WriteLine();

            //*/
            #endregion
            #region pasikartojimas
            /*
            List<int> listOfInts = new List<int>(){2, 7, 78};
            List<int> additionalListOfInts = new List<int>() {10,20,30};
            additionalListOfInts = listOfInts.ConvertAll(COnvertuoju);

            additionalListOfInts.ForEach(PrintAllNumbers);
            */
            #endregion
            #region Klasės darbai

            /*
            List<int> randomNumbers = new List<int>();
            Random rnd = new Random();
            int randomNr = 0;
            for (int i = 0; i < 100; i++)
            {
                randomNr = rnd.Next(1, 100);
                randomNumbers.Add(randomNr);
            }
            Console.WriteLine($"There are {randomNumbers.Count} numbers in the list initially.");
            randomNumbers.RemoveAll(IsLargerThenEigthy);
            Console.WriteLine($"There are {randomNumbers.Count} numbers in the list after removal.");

            randomNumbers.ForEach(PrintEvenNumbers);
            Console.WriteLine();
            Console.WriteLine($"There are {randomNumbers.Count(IsLSmallerThentwenty)} numbers that are smaller than 20.");
            Console.WriteLine($"Sum of all numbers is " + randomNumbers.Sum());
            Console.WriteLine($"Average of all numbers is " + randomNumbers.Average());
            Console.WriteLine($"Smallest number is " + randomNumbers.Min());
            Console.WriteLine($"Largest number is " + randomNumbers.Max());
            Console.WriteLine($"First number is " + randomNumbers.First());
            Console.WriteLine($"Last number is " + randomNumbers.Last());
            randomNumbers.Sort();
            randomNumbers.ForEach(PrintAllNumbers);
            //*/
            #endregion

        }

        static int COnvertuoju(int number)
        {
            return (number * 3);
        }
        static string RemoveNonLetters(string input)
        {
            string resultString = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                char chr = input[i];
                if (char.IsLetter(chr) || chr == ' ')
                {
                    resultString = resultString + chr;
                }
            }
            return resultString;
        }
        static void PrintAllStrings(string text)
        {
            Console.Write(text + " ");
        }
        static void PrintAllNumbers(int number)
        {
            Console.Write(number + ", ");
        }
        static bool IsLSmallerThentwenty(int number)
        {
            return number < 20 ? true : false;
        }
        static bool IsLargerThenEigthy(int number)
        {
            return number > 80 ? true : false;
        }
        static void PrintEvenNumbers(int number)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + ", ");
            }
        }

    }
}
