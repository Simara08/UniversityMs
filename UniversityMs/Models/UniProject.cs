using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class UniProject
    {
        public int Id { get; set; }
        public int TotalMark { get; set; }
        public string Title { get; set; }
        public bool IsDaleted { get; set; }
        public DateTime Deadline { get; set; }
        public int FacultyId { get; set; }
        public int CourseSectionId { get; set; }
        public SectionCourseStruc CourseSection { get; set; }
        public Faculty Faculty { get; set; }
        public ICollection<ProjectUser> ProjectUser { get; set; }
    }
}
