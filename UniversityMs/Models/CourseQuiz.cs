using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class CourseQuiz
    {
        public int Id { get; set; }
        public int CourseSectionId { get; set; }
        public int QuizId { get; set; }
        public SectionCourseStruc SectionCourseStruc { get; set; }
        public Quiz Quiz { get; set; }
    }
}
