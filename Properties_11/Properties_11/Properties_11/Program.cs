using Properties_11.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_11
{
    class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.Name);
            Console.WriteLine(person.SurName);
          
            // neveikia, nes nebera GET propertyje Console.WriteLine(person.Nationality); 
            Console.WriteLine(person.Religion);
            person.Name = "Mantas";
           //nebeera SET property, d4l to negali priskirti reikšmės person.SurName= "Dapkus";
            person.Nationality   = "Lithuanian";
            // set yra private, dėl to keičiamas gali būti tik klasės viduje, o ne iš išorės person.Religion = "Catholic";
            Console.WriteLine("Changed values-------------------");
            Console.WriteLine(person.Name);
            Console.WriteLine(person.SurName);
            // neveikia, nes nebera GET propertyje Console.WriteLine(person.Nationality);
            Console.WriteLine(person.Religion);


        }

    }
}
