using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOverload.ExtraExercises
{
     static class PrintHelper
    {
        public static void Print(string message, params Object[] inputData)
        {
            Console.Write(message + ": ");

            foreach (var item in inputData)
            {
                Console.Write(item + ", ");
            }
        }
        public static void PrintTable(params Object[] inputData)
        {
            foreach (var item in inputData)
            {
                Console.WriteLine(item.GetType() +" " + item);
            }
        }
        
    }
}
