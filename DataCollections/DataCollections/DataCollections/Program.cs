using DataCollections.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollections
{
    public delegate void MySuperFunction(string data);
    class Program
    {
        public delegate void DoOperation(int m1, int m2);
        static void MyMultiply(int m1, int m2)
        {
            Console.WriteLine($"{m1}*{m2}={m1*m2}");
        }
        static void MySum(int m1, int m2)
        {
            Console.WriteLine($"{m1}+{m2}={m1 + m2}");
        }

        static void Main(string[] args)
        {
            DoOperation myOperation = new DoOperation(MyMultiply);
            myOperation += MySum;
            myOperation(5, 8);

            myOperation -= MySum;
            myOperation(5, 8);

            //PrintObj(linkedListas);

            //Queue<string> routine = new Queue<string>();
            //routine.Enqueue("Atsikelti");
            //routine.Enqueue("Nusiprausti");
            //routine.Enqueue("Pavalgyti");
            //routine.Dequeue();
            //Console.WriteLine(routine.Peek());
            //PrintObj(routine);

            Stack<string> kruva = new Stack<string>();
            kruva.Push("paskutinis");
            kruva.Push("priespaskutinis");
            kruva.Push("Pirmas");
            kruva.Pop();

            foreach (string item in kruva)
            {
                Console.WriteLine(item);
            }


            // Item head = new Item("head");
            // Item second = new Item("second");
            // head.ToString();
            // head.Next = second;
            // second.Previous = head;
            // Item third = new Item("third");
            //
            //
            // Item allien = new Item("allien");
            // second.Next = allien;
            // third.Previous = allien;
            // allien.Next = third;
            // allien.Previous = second;
            //
            //
            // second.Next = third;
            // second.Next.Previous = second;
            //
            // Item current = head;
            // while (current != null)
            // {
            //     Console.WriteLine(current);
            //     current = current.Next;
            // }
            // Item last = new Item("last");
            // last.Previous = second.Next;
            // second.Next.Next = last;
            //
            // current = last;
            // while (current != null)
            // {
            //     Console.WriteLine(current);
            //     current = current.Previous;
            // }
            // SortedDictionary<int, string> myFirstDictionary = new SortedDictionary<int, string>()
            // {
            //     { 5,"Puikiai"},
            //     { 1, "Labai blogai" },
            //     { 2, "blogai"}
            // };
            //
            // PrintDic(myFirstDictionary);
            //
            // myFirstDictionary.Add(3, "Vidutiniskai");
            // myFirstDictionary[4] = "Gerai";
            //
            // PrintDic(myFirstDictionary);
            //
            // myFirstDictionary.Remove(3);
            // PrintDic(myFirstDictionary);
            //
            // if (myFirstDictionary.TryGetValue(4, out string result))
            // {
            //     Console.WriteLine("4 exists: " +result);
            // }
            //
            // Console.WriteLine("Contains gerai: " + myFirstDictionary.Values.Contains("Vidutiniskai"));
            // Console.WriteLine("Contains 5: " + myFirstDictionary.Keys.Contains(5));
            //
            // myFirstDictionary.Clear();
            // PrintDic(myFirstDictionary);

        }

        private static bool TestEven(int obj)
        {
            return obj % 2 == 0;
        }

        static void PrintObj(Queue<string> myObj)
        {
            Console.WriteLine("------------------");
            foreach (string item in myObj)
            {
                Console.WriteLine(item);
            }
        }

    }
}
