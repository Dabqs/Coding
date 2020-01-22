using StaticOverload.Excercise;
using StaticOverload.Overloading;
using StaticOverload.ExtraExercises;
using StaticOverload.Interfaces;
using StaticOverload.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            int? number = null;
            double? nr = null;
            bool? isItTrue = null;
            char? key = null;
            string str = null;


            Car test = null;

            if (test != null)
            {
                Console.WriteLine(test?.Manufacturer);
            }
            //test = new Car();
            //if (test != null)
            test?.DoStuff(); // klaustukas sako ar daiktas egzistuoja
           // {
           //     test.DoStuff();
           // }

            /* 
             
              Overloading.Animal animal = new Overloading.Animal(1,"Nobody",true);
            animal.DetermineWhetherCanFly();
              Car car = new Car();
            Console.WriteLine(car);
            Car car2 = new Car("Volvo", "Red", "Diesel power");
            Car car3 = new Car(54987);
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            int[] numbersArr = new int[] { 1, 2, 3, 4, 5 };

            PrintUtil.Print(numbers, "My list of numbers");
            PrintUtil.Print(numbersArr, "My array of numbers");
            PrintHelper.Print("This is the main message", 'c', "stringa",8,7.50);
            PrintHelper.PrintTable('f', 8, "this is message", 987.7);
            foreach (var item in StringHelper.ExtractWords("laba diena, su vistiena"))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(StringHelper.SplitCammelCase("ThisIsMyTest"));
            //*/
            #region paskaitosExamples
            /*
            AllStatic.Show();
            AllStatic.MinNumber = 50;
            Console.WriteLine($"Min number is {AllStatic.MinNumber}");

            NonStaticAtAll nonStaticClass = new NonStaticAtAll("Some initial data",String.Empty);
            nonStaticClass.ShowAllData();
            nonStaticClass.Author = "Derrick Sharp";
            nonStaticClass.ShowAllData();

            MisriKlase.ChangeLineEndNotice("TestNotice");
            MisriKlase misri = new MisriKlase(0, 50);
            misri.ShowLineEnd();

            ActionCounter actionCounter = ActionCounter.GetInstance();
            //*/

            /*
            //Animal animal = new Animal();
            //animal.Move();
            Console.WriteLine(StringUtils.MinorVersion); 
            List<string> words = null;
            string data = "Test data hoes here";
            if (data.Length <= StringUtils.MaxStringLenght)
            {
                words = StringUtils.CutStringIntoWords("Test data, goes here!");
            }
            else
            {
                Console.WriteLine("String is too long");
            }
            if (words != null)
            {
                words.ForEach(Console.WriteLine);
            }
            //*/
            #endregion
        }
    }
}
