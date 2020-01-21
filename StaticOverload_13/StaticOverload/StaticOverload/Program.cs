﻿using StaticOverload.Excercise;
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

            #region paskaitosExamples
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
