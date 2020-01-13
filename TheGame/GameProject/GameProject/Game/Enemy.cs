using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Game
{
    class Enemy : Unit
    {
        int id;

        public Enemy(int id, int x, int y, string name) : base(name, x, y)
        {
            this.id = id;
        }

        public void MoveDown()
        {
            y++;
        }
        public int GetId()
        {
            return id;
        }
    }
}
