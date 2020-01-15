using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.GUI
{
    class TextBlock : GuiObject
    {
        private readonly List<TextLine> textBlocks = new List<TextLine>();
        public TextBlock(int x, int y, int width, List<string> textLines) : base(x, y, width, 1)
        {

        }
        public override void Render()
        {

        }
    }
}
