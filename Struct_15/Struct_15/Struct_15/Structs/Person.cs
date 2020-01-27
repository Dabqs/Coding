using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_15.Structs
{
    class Person : IPrintData
    {
        public string Name;
        public int Age;
        public List<int> FriendsAge = new List<int>();
        public Person(string name, List<int> friendsAge)
        {
            Name = name;
            Age = 15;
            FriendsAge = friendsAge;
        }



        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, age: {Age}, friends age: {String.Join(", ",FriendsAge)}");
        }

    }
}
