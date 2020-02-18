﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double  Score { get; set; }
        public bool IsGettingTuition { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

    }
}
