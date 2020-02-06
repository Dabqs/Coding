using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTraining
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> studentsList = new List<Student>()
            {
                new Student(0,"Mantas",20,5.4,false),
                new Student(1,"Jonas",60,9.6,true),
                new Student(2,"Petras",29,7.6,false),
                new Student(3,"Antanas",12,3.6,false),
                new Student(4,"Aloyzas",35,2.6,false),
                new Student(5,"Martynas",25,8.6,true),
                new Student(6,"Gabrielius",24,9.6,true),
                new Student(7,"Zita",20,5.6,false),
                new Student(0,"Zygis",20,5.4,false),
                new Student(1,"Mantas",50,9.6,true),
                new Student(2,"Karolis",49,7.6,false)
            };

            var whateva = (from st in studentsList
                          where st.Name.Length > 5
                          select new { st.Id, st.Name, status = st.AverageScore < 5 ? "Bad" : st.AverageScore > 8 ? "Good":"AVERAGE" }).GroupBy(st => st.status);

            foreach (var item in whateva)
            {
                Console.WriteLine(item.Key);
                foreach (var student in item)
                {
                    Console.WriteLine(student);
                }
            }                      
        }


          //  var idAndNAme = from st in studentsList
          //                  where st.Age > 20
          //                  orderby st.Name
          //                  select new { st.Id, st.Name };
          //  idAndNAme.ToList().ForEach(Console.WriteLine);


                          //  var groupedAverageStudents = (from st in studentsList
                          //                                where st.AverageScore > 5 && !st.IsGettingTuition
                          //                                select st).GroupBy(st => st.Age);
                          //
                          //  foreach (var item in groupedAverageStudents)
                          //  {
                          //
                          //      Console.WriteLine(item.Key);
                          //      foreach (var st in item)
                          //      {
                          //          Console.WriteLine(st);
                          //      }
                          //     
                          //  }







         //   List < Student > studentsList2 = new List<Student>()
         //   {
         //       new Student(0,"Zygis",20,5.4,false),
         //       new Student(1,"Mantas",50,9.6,true),
         //       new Student(2,"Karolis",49,7.6,false)
         //   };
         //
         //   Console.WriteLine("-------------------------");
         //
         //   List<int> ranges = new List<int>() { 10,20, 30, 40, 50,60,70 };
         //
         //   var groupedList1 = studentsList.GroupBy(x => new {ageGroup= x.Age,x.IsGettingTuition});//anoniminis objektas
         //
         //   var groupedList = from st in studentsList
         //                    group st by st.IsGettingTuition;
         //
         //
         //
         //
         //   foreach (var item in groupedList1)
         //   {
         //       Console.WriteLine("Grouped by: " + item.Key);
         //       Console.WriteLine("++++");
         //       item.ToList().ForEach(Console.WriteLine);
         //   }
         //   Console.WriteLine("-------------------------");
         //
         //   // groupedList.ToList().ForEach(Console.WriteLine);
         //
         //   studentsList = (from student in studentsList
         //                        orderby student.AverageScore descending
         //                        select student).ToList();
         //   studentsList.ForEach(Console.WriteLine);
         //   Console.WriteLine("-------------------------");
         //   studentsList = (from student in studentsList
         //                   orderby student.Age descending
         //                   select student).ToList();
         //   studentsList.ForEach(Console.WriteLine);
         //   Console.WriteLine("-------------------------");
         //   studentsList = studentsList.OrderBy(s => s.Age).ThenByDescending(s => s.AverageScore).ToList();
         //   studentsList.ForEach(Console.WriteLine);
         //
         //
         //   List<int> randomNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
         //
         //   var nonEvenNumbers = from nr in randomNumbers
         //                        where nr % 2 != 0
         //                        select nr;
         //   nonEvenNumbers.ToList().ForEach(Console.WriteLine);
         //   Console.WriteLine();
         //   var dividesBy5 = from nr in randomNumbers
         //                        where nr % 5 == 0
         //                        select nr;
         //   dividesBy5.ToList().ForEach(Console.WriteLine);
         //
         //   Console.WriteLine($"List contains 7: {randomNumbers.Contains(7)}");
         //   Console.WriteLine($"All numbers are even: {randomNumbers.All(nr => nr % 2 ==0)}");
         //   Console.WriteLine($"At least one divides by 8: {randomNumbers.Any(nr => nr % 8 == 0)}");
         //
         //   List<int> anotherNumbers = new List<int>() { 5, 6, 7 };
         //   var powerNumbers = from nr in anotherNumbers
         //                      select nr * nr;
         //   powerNumbers.ToList().ForEach(Console.WriteLine);
         //
         //   var sumNumbers = anotherNumbers.Sum();
         //
         //
         //
         //
         //
         //   //List<Student> studentsThatCanDrinkAlcohol = new List<Student>();
         //   List<Student> studentsThatCanDrinkAlcohol = (from student in studentsList
         //                                     where student.Age >= 21
         //                                     select student).ToList();
         //   Console.WriteLine("Students below can drink alcohol:");
         //   studentsThatCanDrinkAlcohol.ToList().ForEach(Console.WriteLine);
         //   Console.WriteLine();
         //
         //   Console.WriteLine("Students that are getting tuition:");
         //   IEnumerable<Student> studentsThatAreGettingTuition = new List<Student>();
         //
         //   studentsThatAreGettingTuition = studentsList.Where(student => student.IsGettingTuition && student.AverageScore >= 8);//.Select(student => student);
         //   studentsThatAreGettingTuition.ToList().ForEach(Console.WriteLine);
         //   Console.WriteLine();
         //
         //   Console.WriteLine("Students that name is shorter than 8 letters and average score is lower than 4:");
         //   var awkwardStudents = from student in studentsList
         //                                       where student.AverageScore < 4 && student.Name.Length <= 8
         //                                       select student;
         //   awkwardStudents.ToList().ForEach(Console.WriteLine);
         //   Console.WriteLine();
         //
         //   // List<string> goodStudentNames = new List<string>();
         //   Console.WriteLine("These are good in studies:");
         //  var goodStudentNames = from student in studentsList
         //                      where student.AverageScore >= 8 && student.IsGettingTuition
         //                      select student.Name;
         //   goodStudentNames.ToList().ForEach(Console.WriteLine);
         //   Console.WriteLine();
         //
         //   Console.WriteLine("Students ids that name is shorter than 8 letters and average score is lower than 4:");
         //   var badStudentsIDs = from student in studentsList
         //                         where student.AverageScore < 4 && student.Name.Length <= 8
         //                         select student.Id;
         //   badStudentsIDs.ToList().ForEach(Console.WriteLine);
         //
         //
        }
    }

