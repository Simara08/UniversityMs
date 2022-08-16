using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class UserSectionCourseStruc
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
        public int CourseSectionId { get; set; }
        public int Attendance { get; set; }
        public AppUser User { get; set; }
        public Status Status { get; set; }
        public SectionCourseStruc CourseSection { get; set; }
    }
}
