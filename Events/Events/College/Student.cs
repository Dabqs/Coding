using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.College
{
    class Student
    {
        public int id;
        public string name;
        public int age;
        public double averageMark;
        public bool isGettingTuition;

        public override string ToString()
        {
            return $"Student nr.{id} {name} is {age} years old. Getting tuition? {isGettingTuition}, because his score is {averageMark}.";
        }

        public Student(int id, string name, int age, double averageMark, bool isGettingTuition)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.averageMark = averageMark;
            this.isGettingTuition = isGettingTuition;
        }

    }
}
