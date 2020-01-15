using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.GUI
{
    class Frame : GuiObject
    {
        private char renderChar;

        public Frame(int x, int y, int width, int height, char frameCharacter) : base(x, y, width, height)
        {
            renderChar = frameCharacter;
        }

        public void Render() 
        {
            //print upper horizontal border
            SkipVertical(y);
            SkipHorizontal(x);
            PrintHorizontalBorder();

            //print side borders
            PrintVerticalBorders();

            //print upper horizontal border
            SkipHorizontal(x);
            PrintHorizontalBorder();
        }
        #region Helper functions
        private void PrintVerticalBorders()
        {
            for (int i = 0; i < y; i++)
            {
                Console.WriteLine();
                SkipHorizontal(x);
                Console.Write(renderChar);
                SkipHorizontal(width -1);
                Console.Write(renderChar);
            }
            Console.WriteLine();
        }
        private void PrintHorizontalBorder()
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write(renderChar);
            }
        }
        private void SkipHorizontal(int x)
        {
            for (int i = 0; i < x -1; i++)
            {
                Console.Write(" ");
            }
        }
        private void SkipVertical(int y)
        {
            for (int i = 0; i < y -1; i++)
            {
                Console.WriteLine();
            }
        }
        #endregion
    }
}
