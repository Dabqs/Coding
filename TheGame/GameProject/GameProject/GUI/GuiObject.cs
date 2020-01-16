using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.GUI
{
    abstract class GuiObject
    {
        protected int Height { get; set; }
        protected int Width { get; set; }
        protected int X { get; set; }
        protected int Y { get; set; }

        public GuiObject(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public abstract void Render();

    }
}
