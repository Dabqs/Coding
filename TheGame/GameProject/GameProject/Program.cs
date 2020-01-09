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
            Hero mainHero = new Hero("Mantas",0,0);
            myGame.SetHero(mainHero);
            int enemyCount = 0;

            List<Enemy> enemies = new List<Enemy>();
            for (int i = 0; i < 10; i++)
            {
                enemies.Add(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }


            foreach (Enemy enemy in enemies)
            {
                myGame.AddEnemy(enemy);
            }

            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }

        }
    }
}
