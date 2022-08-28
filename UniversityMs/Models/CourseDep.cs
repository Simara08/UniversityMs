using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class CourseDep
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public Course Course { get; set; }
    }
}
