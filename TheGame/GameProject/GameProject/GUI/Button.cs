using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.GUI
{
    class Button : GuiObject
    {
        private Frame activeFrame;
        private bool isActive = false;
        private Frame notActiveFrame;
        private TextLine textLine;

        public Button(int x, int y, int width, int height, string buttonCaption) : base(x, y, width, height)
        {
            activeFrame = new Frame(x, y, width, height, '#');
            notActiveFrame = new Frame(x, y, width, height, '+');
            textLine = new TextLine(x + 1, ((height - 2) / 2) + 1 + y, width, buttonCaption);
        }
        public void Render()
        {
            if (isActive)
            {
                activeFrame.Render();
            }
            else
            {
                notActiveFrame.Render();
            }
        }
        public void SetActive()
        {
            isActive = true;
        }
    }
}
