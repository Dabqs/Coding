using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasės_8.Test
{
    class Student : Person
    {
        private double averageScore;
        private bool isGetingSomething;
        private string livingRoom;
        public Student(string name, double age, string livingRoom = "Sauletekio al. 6") : base(name,age)
        {
            averageScore = 0;
            isGetingSomething = false;
            this.livingRoom = livingRoom;
        }
        public void SetAverageScore(double averageScore)
        {
            this.averageScore = averageScore;
        }
        public void ChangeStudentScholarshipStatus(bool shouldGet)
        {
            isGetingSomething = shouldGet;
            income = isGetingSomething ? 100 : 0;
        }


    }
}
