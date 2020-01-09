using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Game
{
    class Enemy
    {
        int x;
        int y;
        int id;
        string name;

        public Enemy(int id, int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.id = id;
            this.name = name;
        }

        public void MoveDown()
        {
            y--;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Enemy's {name} (id: {id}) coordinates are [{x};{y}].");
        }
        public int GetId()
        {
            return id;
        }
    }
}
