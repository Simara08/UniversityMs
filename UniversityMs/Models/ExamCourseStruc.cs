using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class ExamCourseStruc
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public int CourseSectionId { get; set; }
        public Exam Exam { get; set; }
        public SectionCourseStruc SectionCourseStruc { get; set; }
    }
}
