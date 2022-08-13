﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class CourseDep
    {
        public int CourseId { get; set; }
        public int DepId { get; set; }
        public Department Department { get; set; }
        public Course Course { get; set; }
    }
}
