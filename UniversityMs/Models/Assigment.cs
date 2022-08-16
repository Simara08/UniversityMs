using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Assigment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Mark { get; set; }
        public string link { get; set; }
        public ICollection<AssigmentCourseSection> AssigmentCourseSection { get; set; }
        public ICollection<AssigmentUser> AssigmentUser { get; set; }
        public bool IsDaleted { get; set; }
    }
}
