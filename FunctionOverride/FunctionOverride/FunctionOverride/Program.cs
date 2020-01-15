using FunctionOverride.Zoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Bird bird = new Bird();
            Animal birdAsAnimal = bird;

            List<Animal> animals = new List<Animal>();
            Horse horse = new Horse();
            animals.Add(bird);
            animals.Add(horse);
            //*
animal.Move();
bird.Move();

birdAsAnimal.Move();
//*/
            Console.WriteLine("All animals moves---------------");
            foreach (Animal item in animals)
            {
                item.Move();
            }




        }
    }
}
