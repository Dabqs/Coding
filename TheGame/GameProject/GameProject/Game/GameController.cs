using GameProject.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Game
{
    class GameController
    {
        private GameScreen myGame;
        public GameController()
        {

        }
        public void StartGame()
        {
            InitGame();
            StartGameLoop();

            
        }
        public void StartGameLoop()
        {
            bool needToRender = true;
            do
            {
                Console.Clear();
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            needToRender = false;
                            break;
                        case ConsoleKey.RightArrow:
                            myGame.MoveHeroRight();
                            break;
                        case ConsoleKey.LeftArrow:
                            myGame.MoveHeroLeft();
                            break;
                    }
                }

                myGame.Render();

                System.Threading.Thread.Sleep(250);

            } while (needToRender);
        }
        public void InitGame()
        {
            Random rnd = new Random();
            myGame = new GameScreen(10, 20);
            myGame.SetHero(new Hero("Mantas", 0, 0));

            int enemyCount = 0;
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }
        }
    }
}
