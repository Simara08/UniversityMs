using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class TimeSchedule
    {
        public int Id { get; set; }
        public DateTime Starttime { get; set; }
        public DateTime EndTime { get; set; }
        public string Day { get; set; }
        public int ClassId { get; set; }
        public int CourseSection { get; set; }
        public Class Class { get; set; }
        public bool IsDaleted { get; set; }
        public SectionCourseStruc SectionCourseStruc { get; set; }
    }
}
