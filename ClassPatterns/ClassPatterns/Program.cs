using ClassPatterns.ClassesExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("hTTPS://WWW.GOOGLE.LT");
            var result = client.GetStringAsync("").Result;
            Console.WriteLine(result);
            FirstSingletonClass singleton1 = FirstSingletonClass.GetInstance();
            FirstSingletonClass singleton2 = FirstSingletonClass.GetInstance();

            if (singleton1 == singleton2 && singleton1 != null)
            {
                Console.WriteLine("All good");

            }
            else
            {
                Console.WriteLine("Bad. Objects are either different or empty.");
            }

            Proxy myProxy = new Proxy(new RealObject());
            myProxy.DoStuff();
            MyCommand myCommand = new MyCommand();
            myCommand.Execute();

        }
    }
}
