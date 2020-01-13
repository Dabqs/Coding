using GameProject.Game;
using GameProject.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController myGame = new GameController();
            myGame.StartGame();
        }

    }
}
