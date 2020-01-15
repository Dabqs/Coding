using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.GUI
{
    class Gamewindow : Window
    {
        private Button creditsButton;
        private Button quitButton;
        private Button startButton;
        private TextBlock titleTextBlock;

        public Gamewindow(int x, int y,int width, int height, char frameCharacter) : base(x, y, width, height, frameCharacter)
        {

        }
        public void Render()
        {

        }

    }
}
