using GameProject.Game;
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
            Random rnd = new Random();
            GameScreen myGame = new GameScreen(10, 20);
            myGame.SetHero(new Hero("Mantas", 0, 0));

            int enemyCount = 0;
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }
            myGame.Render();

        }
    }
}
