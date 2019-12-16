using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsTest(8, new double[] { 4,5.8,8.7},"string","second string","third string");
          //  DemoFunction("test", 12, false, "taip", 'n', 23);
            /*
            ArrayReferenceTest();
            */
            /*
            string[] myStrings = FiveStrings();
            Console.WriteLine(String.Join(String.Empty, myStrings)); //atspausdinti be tarpu

            for (int i = 4; i > -1; i--) // atspausdinti atvirkstine tvarka
            {
                Console.Write(myStrings[i]);
            }
            Console.WriteLine();
            string[] myStringsWithoutDuplicates = ReplaceDuplicates(myStrings);
            Console.WriteLine(String.Join(" ", myStringsWithoutDuplicates));// atspausdinti be duplikatu

            string[] reorderedArray = OrderArray(myStringsWithoutDuplicates);
            Console.WriteLine(string.Join(" ", reorderedArray));
            //*/
        }
        static void ParamsTest(int number, double[] doubleArr,params string[] stringArr)
        {
            Console.WriteLine(number);
            foreach (double dbl in doubleArr)
            {
                Console.Write(dbl + " ");
            }
            Console.WriteLine() ;
            foreach (string str in stringArr)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }
        static void DemoFunction(string message, params object[] restOfParameters)
        {
            foreach (var item in restOfParameters)
            {
                Console.WriteLine(item);
                if (item is string)
                {
                    string mystring = item as string;
                    Console.WriteLine($"{item} is a string");
                }
            }
        }
        static void ArrayReferenceTest()
        {
            int[] referenceArr = { 1, 2, 3, 4, 5 };
            int[] cloneArr = (int[])referenceArr.Clone();
            foreach (var item in referenceArr)
            {
                Console.WriteLine(item);
            }
            referenceArr = SpoilArray(referenceArr);
            foreach (var item in referenceArr)
            {
                Console.WriteLine(item);
            }
            foreach (var item in cloneArr)
            {
                Console.WriteLine(item);
            }

        }
        static int[] SpoilArray(int[] refArray)
        {
            foreach (var item in refArray)
            {
                refArray[Array.IndexOf(refArray, item)] = -1;
            }
            return refArray;
        }

        static string[] FiveStrings()
        {
            string[] strings = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter string No.{i + 1}");
                strings[i] = Console.ReadLine();
            }
            return strings;
        }
        static string[] ReplaceDuplicates(string[] myStrings)
        {
            var stringArrWithoutDuplicates = new string[5];
            for (int i = 0; i < myStrings.Length; i++)
            {
                if (!stringArrWithoutDuplicates.Contains(myStrings[i]))
                {
                    stringArrWithoutDuplicates[i] = myStrings[i];
                }
                else
                {
                    stringArrWithoutDuplicates[i] = "!";
                }
            }
            return stringArrWithoutDuplicates;
        }
        static string[] EliminateDuplicates(string[] stringArr, string stringToReplaceWith)
        {
            for (int i = 0; i < stringArr.Length; i++)
            {
                for (int j = i + 1; j < stringArr.Length; j++)
                {
                    if (stringArr[i] == stringArr[j])
                    {
                        stringArr[j] = stringToReplaceWith;
                    }
                }
            }
            return stringArr;
        }
        static string[] OrderArray(string[] stringsWithoutDuplicates)
        {
            for (int i = 0; i < stringsWithoutDuplicates.Length; i++)
            {
                if (stringsWithoutDuplicates[i] == "!")
                {
                    for (int j = stringsWithoutDuplicates.Length - 1; j > -1; j--)
                    {
                        stringsWithoutDuplicates[i] = stringsWithoutDuplicates[j];
                        stringsWithoutDuplicates[j] = "!";
                        break;
                    }
                }
            }
            return stringsWithoutDuplicates;
        }
    }
}

