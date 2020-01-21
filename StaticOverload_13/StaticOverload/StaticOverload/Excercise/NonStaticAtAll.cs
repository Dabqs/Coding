using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOverload.Excercise
{
    class NonStaticAtAll
    {
        private string Data { get; set; }
        public string Author { get; set; } 

        public NonStaticAtAll(string data, string author)
        {
            Data = data;

            DetermineAuthor(author);
        }
        public void ShowAllData()
        {
            Console.WriteLine($"Data is: {Data} and Author is {Author}");
        }
        private void DetermineAuthor(string authorData)
        {
            if (String.IsNullOrWhiteSpace(authorData))
            {
                Author = "Unknown";
            }
            else
            {
                Author = authorData;
            }

        }
    }
}
