using Klasės_8.Basketball;
using Klasės_8.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasės_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //*
            Console.WriteLine("Pasirinkite kamuolio spalvą: ");
            string ballColor = Console.ReadLine();

            Ball kamuolys = new Ball(ballColor);
            Referee teisėjas = new Referee("Sukys","vyr teisėjas",50);
            Player basketbAllPlayer = new Player("Mantas", "power forward", 100);
            Basket krepsys = new Basket(3.05, "red", "medziaginis");
            Floor grindys = new Floor(7);

            Console.WriteLine($"Ball color is '{kamuolys.GetBasketballColor()}'");
            kamuolys.SetBasketBallColor("red");
            Console.WriteLine($"Ball color is '{kamuolys.GetBasketballColor()}'");

            Console.WriteLine("Basketball height before adjustment is " + krepsys.GetBasketballHeight());
            krepsys.AdjustHeight(3.63);
            Console.WriteLine("Basketball height after adjustment is " + krepsys.GetBasketballHeight());
            krepsys.AdjustHeight(-3.63);
            Console.WriteLine("Basketball height after yet another adjustment is " + krepsys.GetBasketballHeight());


            basketbAllPlayer.GetPlayerInformation();
            basketbAllPlayer.Substitute(true);
            basketbAllPlayer.GetPlayerInformation();
            teisėjas.ShowRefereeInformation();

            
            //*/

            /*
            HammerTime hammerTime = new HammerTime(15);
            Console.WriteLine(hammerTime.GetHitCount());

            hammerTime.HitNail();
            Console.WriteLine(hammerTime.GetHitCount());
            Console.WriteLine("Length is " + hammerTime.GetLenght());
            //*/
        }
    }
}
