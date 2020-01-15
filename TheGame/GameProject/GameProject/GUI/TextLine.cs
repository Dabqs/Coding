using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.GUI
{
    class TextLine : GuiObject
    {
        private readonly string data;

        public TextLine(int x, int y, int width, string data) : base(x, y, width,1)
        {
            this.data = data;
        }
        public override void Render()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(data);
        }
    }
}
