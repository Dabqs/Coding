using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Models
{
    public class Student
    {
        [Range(0,10)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(0.0,10.0)]
        public double  Score { get; set; }
        public bool IsGettingTuition { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

    }
}
