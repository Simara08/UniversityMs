using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsDaleted { get; set; }
        public int CourseSectionId { get; set; }
        public SectionCourseStruc CourseSection { get; set; }
        public AppUser User { get; set; }
        public ICollection<GradePoint> GradePoint { get; set; }
    }
}
