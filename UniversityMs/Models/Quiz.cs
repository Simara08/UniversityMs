using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Mark { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public bool IsDaleted { get; set; }
        public ICollection<UserQuiz> UserQuize { get; set; }
        public ICollection<CourseQuiz> CourseQuiz { get; set; }
    }
}
