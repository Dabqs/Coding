using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main()
        {
            Uzduotis.IvedimasIPrograma();
            Kintamieji.kintamujuPaskaitai();

            Console.ReadLine();
            //

            //CTRL+ALT+L indentation sutvarko
            // su ALT gali žymėti daug eilučių ir visos pasikeis

            //Jeigu viršuje padarai standartinį komentarą su //* ir apačioje //*/, būna labai lengva atblokuoti
            /*
            Console.WriteLine("Hello world");
            Console.ReadLine();
            Console.ReadKey();
            //*/
            Console.WriteLine("Hello world");
            Console.WriteLine(" Labas " +156 + "-viso gero!");
            Console.WriteLine("mano vardas yra \"{0}\", pavardė yra {1}. \nMan yra {2} \tmetų.","Mantas","Dapkus","30");
            //*/
        }
    }
}
