using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Game
{
    class GameScreen
    {
        int width;
        int height;
        Hero hero;
        List<Enemy> enemies = new List<Enemy>();

        public GameScreen(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }
        public void MoveHeroRight()
        {
            hero.MoveRight();
        }
        public void MoveHeroLeft()
        {
            hero.MoveLeft();
        }
        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }
        public void MoveAllEnemiesDown()
        {
            foreach (Enemy theEnemy in enemies)
            {
                theEnemy.MoveDown();
            }
        }

        public Enemy GetEnemyById(int id)
        {
            return enemies.Where(x => x.GetId() == id).FirstOrDefault();
        }
        public void Render()
        {
            hero.PrintInfo();
            Console.WriteLine();
            foreach (Enemy theEnemy in enemies)
            {
                theEnemy.PrintInfo();
            }
        }

    }
}
