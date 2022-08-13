using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class CourseSturucture
    {
        public int Id { get; set; }
        public int LectureNo { get; set; }
        public int Attendance { get; set; }
        public Course Course { get; set; }
    }
}
