using System;

namespace LinqTraining
{
    internal class Student 
    {
        private int studentCount = 0;
        public int Age { get; set; }
        public int Id { get; }

        public Student(int id, string name, int age, double averageScore, bool isGettingTuition)
        {
            Id = id;
            Name = name;
            Age = age;
            AverageScore = averageScore;
            IsGettingTuition = isGettingTuition;
        }

        public override string ToString()
        {
            return $"Student ID {Id} is {Name}. He/she's {Age} years old. Average score is {AverageScore} and so it is {IsGettingTuition.ToString().ToLower()} that he gets tuition.";
        }

        public int CompareTo(Student obj)
        {
            return (int)((this.AverageScore - obj.AverageScore *100));
        }

        public string Name { get; set; }
        public double AverageScore { get; internal set; }
        public bool IsGettingTuition { get; internal set; }
    }
}