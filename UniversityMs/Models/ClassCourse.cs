using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class ClassCourse
    {
        public int CourseId { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public Course Course { get; set; }
    }
}
