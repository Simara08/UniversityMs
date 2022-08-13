using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Exam> Exam { get; set; }
        public  ICollection<ClassCourse> Coursecourse { get; set; }
    }
}
