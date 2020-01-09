using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasės_8.Basketball
{
    class Player
    {
        public string name;
        public string position;
        private double weight;
        public bool isOnCourt;

        //*
        public Player(string name, string position, double weight)
        {
            this.name = name;
            this.position = position;
            this.weight = weight;
            isOnCourt = false;
        }//*/
        public void Substitute(bool shouldBeOnCourt)
        {
            isOnCourt = true;
        }
        public void SetAsPlaymaker()
        {
            position = "playmaker";
        }

        public void GetPlayerInformation()
        {
            string isPlaying = isOnCourt ? "is playing on the court" : "is sitting on the bench";
            Console.WriteLine($"Player name is: '{name}', it's position is '{position}' and he weights {weight}kg. Currently he {isPlaying}.");
        }
    }
}
