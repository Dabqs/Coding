using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_15.Structs
{
    class WeddingDay
    {
        public Weekdays WeddingDate { get; set; }

        public WeddingDay(Weekdays weddingDate)
        {
            WeddingDate = weddingDate;
        }
        public void ShowWhichDayYourWeddingIs() {
            Console.WriteLine($"Your wedding will take place on " + WeddingDate.ToString());
        }
        public void CheckIfDayIsntWeird()
        {

            switch ((int)WeddingDate)
            {
                case 4:
                    Console.WriteLine(Weekdays.Thursday +"? Aint that a weird day for a wedding?");
                    break;
                case 6:
                    Console.WriteLine($"Now {WeddingDate.ToString()} is a perfect day for a wedding.");
                    break;
                default:
                    break;
            }
        }

    }
}
