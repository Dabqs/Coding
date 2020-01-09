using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Game
{
    class Hero
    {
        int x;
        int y;
        string name;

        public Hero(string name, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public void MoveRight()
        {
            x++;
        }
        public void MoveLeft()
        {
            x--;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Hero's {name} coordinates are [{x};{y}]");
        }
    }
}
