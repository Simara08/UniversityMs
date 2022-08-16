using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public bool IsDaleted { get; set; }
        public CourseSturucture CourseSturucture { get; set; }
        public  ICollection<CourseDep> CourseDep { get; set; }
        public  ICollection<ClassCourse> Coursecourse { get; set; }
        public ICollection<SemOffCourse> SemOffCourse { get; set; }
        public ICollection<CourseTopic> CourseTopic { get; set; }
    }
}
