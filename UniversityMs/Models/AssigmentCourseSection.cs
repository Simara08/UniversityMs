using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class AssigmentCourseSection
    {
        public int Id { get; set; }
        public int AssigmentId { get; set; }
        public int CourseSectionId { get; set; }
        public Assigment Assigment { get; set; }
        public SectionCourseStruc SectionCourseStruc { get; set; }
    }
}
