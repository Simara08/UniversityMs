using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class SectionCourseStruc
    {
        public int Id { get; set; }
        public int CourseStrucId { get; set; }
        public int SectionId { get; set; }
        public bool IsDaleted { get; set; }
        public CourseSturucture CourseStruc { get; set; }
        public Section Section { get; set; }
        public ICollection<FacultyCourseStruc>FacultyCourseStruc { get; set; }
        public ICollection<UserSectionCourseStruc> UserSectionCourseStruc { get; set; }
        public ICollection<CourseQuiz> CourseQuiz { get; set; }
        public ICollection<Grade> Grade { get; set; } 
        public ICollection<ExamCourseStruc> ExamCourseStruc { get; set; }
        public ICollection<UniProject> UniProject { get; set; }
        public ICollection<AssigmentCourseSection> AssigmentCourseSection { get; set; }
        public ICollection<TimeSchedule> TimeSchedule { get; set; }
    }
}
