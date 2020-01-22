using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOverload.Utils
{
    class Car
    {
        public string Manufacturer { get; set; }
        public string Color { get; set; }
        public string EngineType { get; set; }

        public Car(string manufacturer= "BMW", string color= "White", string engineType= "V6")
        {
            Manufacturer = manufacturer;
            Color = color;
            EngineType = engineType;
        }
        public Car(int modelnumber)
        {
            //GetModelDataByID();
        }

        internal void DoStuff()
        {
            Console.WriteLine("Car does stuff...");
        }

        public override string ToString()
        {
            return base.ToString()+ $"My car is {Manufacturer}. It's color is {Color}. And engine is {EngineType}.";
        }
    }
}
