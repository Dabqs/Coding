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
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }

        public override void Render() 
        {

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(x-1 , y -1 +i);
                if (i == 0 || i == (height -1))
                { //prints top and bottom border
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write(renderChar);
                    }
                }
                else
                { //prints top and bottom border
                    for (int j = 0; j < width; j++)
                    {
                        if (j == 0 || j== width -1)
                        {
                            Console.Write(renderChar);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
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
