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

        public override void Render() 
        {

            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X-1 , Y -1 +i);
                if (i == 0 || i == (Height -1))
                { //prints top and bottom border
                    for (int j = 0; j < Width; j++)
                    {
                        Console.Write(renderChar);
                    }
                }
                else
                { //prints top and bottom border
                    for (int j = 0; j < Width; j++)
                    {
                        if (j == 0 || j== Width -1)
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
    }
}
