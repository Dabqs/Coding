using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasės_8.Basketball
{
    class Basket
    {
         double height;
         string rimType;
         string netType;

        public Basket(double height, string rim, string net)
        {
            this.height = height;
            rimType = rim;
            netType = net;
        }

        
        public void ChangeRim()
        {

        }
        public void AdjustHeight(double height)
        {
            if (height>0)
            {
                this.height = height;
            }
            else
            {
                Console.WriteLine("A negative height was selected for the basket.");
                this.height = 0;
            }
        }
        public double GetBasketballHeight()
        {
            return height;
        }
        public void ChangeNet()
        {

        }
    }
}
