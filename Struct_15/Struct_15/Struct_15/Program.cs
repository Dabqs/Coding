using Struct_15.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_15
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder myString = new StringBuilder("Teksto pradzia.");
            myString.AppendLine("Va tai dabar pridejau jau i antra eilute.");

            Console.WriteLine($"Stringbuilderio lenght yra "+myString.Length);
            myString.Append(" Na dar viena sakini pridesiu i ta pacia antra eilute.");

            Console.WriteLine(myString);
            myString.Replace('a', 'b');
            Console.WriteLine(myString);
            myString.AppendFormat("This must be added here: {0}", 8);
            myString.Insert(0, 10);
            Console.WriteLine(myString);
            Console.WriteLine();
            myString.Remove(10, 10);
            Console.WriteLine(myString);
           // string la = "labas";
           // la = la.Trim('l');
           // Console.WriteLine(la);
           // try
           // {
           // int test = Convert.ToInt32(Console.ReadLine());
           //// masyvas[5] = test;
           //
           // }
           // catch (FormatException ex)
           // {
           //
           //     Console.WriteLine("Nu ne skaiciu ivedei gi: " + ex.Message);
           // }
           // catch (IndexOutOfRangeException ex)
           // {
           //     Console.WriteLine("Masyvas gi turi tik 3 elementu vieta, o tu bandai i 5 imest: " + ex.Message);
           //     
           // }
           // finally
           // {
           //     Console.WriteLine("Have a nice day anyway...");
           // }

            //  WeddingDay weddingDay = new WeddingDay(Weekdays.Thursday);
            //  weddingDay.ShowWhichDayYourWeddingIs();
            //  weddingDay.CheckIfDayIsntWeird();
            //  weddingDay.WeddingDate = Weekdays.Saturday;
            //  weddingDay.ShowWhichDayYourWeddingIs();
            //  weddingDay.CheckIfDayIsntWeird();


            //   Person person = new Person("Mantas", new List<int> { 15, 54, 87 });
            //   person.PrintInfo();
            //   person.Age = 30;
            //   person.PrintInfo();
            //
            //   Address address = new Address("Sartu");
            //   address.PrintInfo();
            //   address.HouseNumber = 78;
            //   address.PrintInfo();
            //
            //   GiveNewValues(person, address);
        }
        static public void PickADay(Weekdays day)
        {
            Console.WriteLine("You have chosen " + day.ToString());
        }
        static public void GiveNewValues(Person person, Address address)
        {
            Console.WriteLine("----------------------");
            person.PrintInfo();
            person.Age = 20;
            person.PrintInfo();
            address.PrintInfo();
            address.StreetName = "Zirgu";
            address.PrintInfo();
        }
    }
}
