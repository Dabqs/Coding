using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasės_8.Basketball
{
    class Referee
    {
        public string name;
        public int rating;
        private decimal salary;
        public string role;

        public Referee(string name,string role, int rank)
        {
            this.name = name;
            this.role = role;
            this.rating = rank;
            SetSalaryByRank();
            
        }
        public void ShowRefereeInformation()
        {
            Console.WriteLine($"The referee {name} will be judging this game. His salary is {salary}.");
        }
        void SetSalaryByRank()
        {
            salary = 110 * rating;
        }
        void SetAsTheHeadReferee()
        {

        }
    }
}
