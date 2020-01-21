using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOverload.Interfaces
{
    class Animal : IMoveable
    {
        //*
        public string Data { get; }
        private readonly string data = "test";
        public Animal()
        {
            Data = "test";
        }
        public void ChangeData()
        {
        }
        
        public void Move()
        {
            Console.WriteLine();
        }
        //*/
    }
}
