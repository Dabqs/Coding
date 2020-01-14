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

        public Button(int x, int y, int width, int height) : base(x, y, width, height)
        {
        }
        public void Render()
        {

        }
        public void SetActive()
        {

        }
    }
}
