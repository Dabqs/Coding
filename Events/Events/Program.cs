using Events.Bank;
using Events.College;
using Events.Externsions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(6.PowerTwo()); 
            List<Student> listOfStudents = new List<Student>
            {
                new Student(1, "Mantas",20, 9.8d, true),
                new Student(2, "Petras",38, 8.8d, false),
                new Student(3, "Jonas",48, 6.6d, true),
                new Student(4, "Antanas",25, 5.8d, false),
                new Student(5, "Gabrielius",30, 9.4d, true),
                new Student(6, "Mykolas",14, 6.4d, true),
                new Student(7, "Algirdas",13, 2.4d, true),
                new Student(8, "Andrius",16, 3.4d, true),
                new Student(9, "Virginijus",30, 9.4d, true)
        };

            Student studentMantas = listOfStudents.Find(s => s.name == "Mantas"); //find grazina pirma rasta arba null

            List<Student>  goodStudents = listOfStudents.FindAll(s => s.isGettingTuition && s.averageMark >8);
            Console.WriteLine("Good students:");
            goodStudents.ForEach(Console.WriteLine);
            Console.WriteLine();
            List<Student> studentsThatCanDrinkAlkohol = listOfStudents.FindAll(s => s.age >= 21);
            Console.WriteLine("These students are allowed to drink alkohol");
            studentsThatCanDrinkAlkohol.ForEach(Console.WriteLine);
            Console.WriteLine();

            List<Student> randomStudents = listOfStudents.FindAll(s => s.name.Length < 9 && s.averageMark <4);
            randomStudents.ForEach(Console.WriteLine);



            //Student student = new Student
            //{
            //    Name = "Petras",
            //    Age = 15,
            //    IsgettingTuition = true,
            //    AverageScore = 5.6
            //};

            //   MailSender mailSender = new MailSender("mymail@super.com");
            //   FileLogger fileLogger = new FileLogger("Path.txt");
            //   MyBank myBank = new MyBank("my bank", 1000);
            //   myBank.OnMoneyAdded += mailSender.SendEmail;
            //   myBank.OnMoneyConversion += mailSender.SendEmail;
            //   myBank.OnAnyTransaction += mailSender.SendEmail;
            //   myBank.AddMoney(100);
            //   myBank.ConvertToCurrency(100, '$', 1.2436f);

        }

        private static bool TestGoodStudent(Student student)
        {
            return student.isGettingTuition ? true : false;
        }
    }
}
