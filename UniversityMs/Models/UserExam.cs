using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class UserExam
    {
        public int AppUserId { get; set; }
        public int ExamId { get; set; }
        public AppUser User { get; set; }
        public Exam Exam { get; set; }
    }
}
