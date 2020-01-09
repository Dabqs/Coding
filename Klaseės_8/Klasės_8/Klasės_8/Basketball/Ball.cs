using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasės_8.Basketball
{
    class Ball
    {
        private double weight;
        private string color;
        private double inflatePressure;
        
      //*
        public Ball(string color)
        {
            inflatePressure = 9.4;
            weight = 5.6;
            this.color = color;

        }//*/

        public void SetBasketBallColor(string color)
        {
            this.color = color;
        }
        public string GetBasketballColor()
        {
            return color;
        }
        void Inflate()
        {

        }
        void Paint()
        {

        }
        void ValidateWeight()
        {

        }

    }
}
