using Pasikartojimas_14.LiveObjects;
using Pasikartojimas_14.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasikartojimas_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Human boss = new Human("Mantas");
            Company company = new Company(boss, "VilniusCodingSchool");

            company.OfficePet = new Dog("Doggo");

            company.HireWorker(new Worker("Valytojas Petras", 400));
            company.HireWorker(new Worker("Programuotoja Liveta", 2500));

            company.AddClient(new Client("Norian"));
            company.AddClient(new Client("OpusCapita"));

            company.PrintInfo();

            Console.ReadLine();

        }
    }
}
