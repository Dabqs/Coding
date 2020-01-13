﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Game
{
    class Unit
    {
        string name;
        protected int x;
        protected int y;
        public Unit(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{name} is at [{x};{y}].");
        }
    }
}
