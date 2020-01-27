using Namespaces.Klases;
using Namespaces.MyUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myStringArr = new string[] { "vienas", "Du", "Trys" };
            //string myTxtPath = "../MyTestFile.txt"; <<<< padaro viena zingsni atgal nuo katalogo
            string myTxtPath = "../../MyTestFile.txt";
            string myTestFilePath = "TestFile.txt";

            FileInfo myFile = new FileInfo(myTxtPath);
            if (File.Exists(myTestFilePath))
            {
                File.Delete(myTestFilePath);
            }
            Console.WriteLine(File.Exists(myTestFilePath));
            using (File.Create(myTestFilePath)) 
            {
                
            }
            Console.WriteLine(File.Exists(myTestFilePath));
            File.AppendAllLines(myTestFilePath, myStringArr);
            File.CreateText("Test2.txt");
            File.GetAccessControl(myTestFilePath);


            string myText = string.Empty;
            File.WriteAllText(myTxtPath, "This is all text that i want to add to this file.\nMaybe this one extra line too.");
            //File.Delete(myTxtPath);
            myText = File.ReadAllText(myTxtPath);
            Console.WriteLine(myText);
            File.AppendAllText(myTxtPath, "Let me add this too.");


            MyLibrary.Enemy enemy1 = new MyLibrary.Enemy();
            MyLibs.Enemy enemy2 = new MyLibs.Enemy();
            enemy1.PrintName();
            Console.WriteLine(enemy2.Name);

            enemy1.DoStuff();
            enemy2.DoStuff();

            GameUtils.PrintGoodMoto();
        }
    }
}
