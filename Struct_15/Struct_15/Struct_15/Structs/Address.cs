using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_15.Structs
{
    struct Address : IPrintData
    {
        public string StreetName;
        public int HouseNumber;
       public List<int> NeighborsNumbers;

        public Address(string streetName)
        {
            StreetName = streetName;
            HouseNumber= 10;
           NeighborsNumbers= new List<int>{ 2,1,5,7};
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Street name is: {StreetName}, house number is: {HouseNumber}.");        }
    }
}
