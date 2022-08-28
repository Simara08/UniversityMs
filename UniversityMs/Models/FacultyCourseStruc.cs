using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class FacultyCourseStruc
    {
        public int Id { get; set; }
        public int FacultyId { get; set; }
        public int SectionCourseStrucId { get; set; }
        public Faculty Faculty { get; set; }
        public SectionCourseStruc SectionCourseStruc { get; set; }
    }
}
