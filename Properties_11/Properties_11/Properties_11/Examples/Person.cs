using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_11.Examples
{
    class Person
    {
        public string Name
        {
            get
            {
                Console.WriteLine("Getting name");
                return name;
            }
            set
            {
                Console.WriteLine("Setting name");
                name = value;
            }
        }
        public string SurName
        {
            get
            {
                Console.WriteLine("Getting surname");
                return surName;
            }
            //set { surName = value; }
        }
        public string Nationality
        {
            // get { return nationality; }
            set
            {
                Console.WriteLine("Setting nationality");
                nationality = value;
            }
        }
        public string Religion
        {
            get
            {
                Console.WriteLine("Getting religion");
                return religion;
            }
            private set
            {
                Console.WriteLine("Setting religion");
                religion = value;
            }
        }

        private string name = "no name";
        private string surName = "No surname";
        private string nationality = "no nationality";
        private string religion = "no religion";




        #region Examples
        /*
        public string jeans;

        private string name = "No name";
        //public string name { get; set; } = "no name"; //veikia tik jeigu vienoj eilut4je
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
            }
        }
        double age;
        protected int income;
        private double height;
        public string surname { get; set; } = "No surname";
        /*
         private string surName = "No surname given";
         public string Surname
        {
            get { return surName; }
            set { surName = value; }
        }

        //public double height { get; set; }
        public double Height
        {
            get
            {
                Console.WriteLine("Why do you want to know my height?");
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Error. Height is negative");
                }
            }
        }

        public Person(string name, double age)
        {
            this.name = name;
            this.age = age;
        }
        public void IntroduceYourself()
        {
            Console.WriteLine($"My name is {name} and i'm {age} yo. My height is " + height);
        }

        public void SetAge(double newAge)
        {
            if (newAge > 0)
            {
                age = newAge;
            }
            else
            {
                Console.WriteLine("Age is negative");
            }
        }
        public double GetAge()
        {
            return age;
        }
        */
        #endregion
    }
}
