using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Mark { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public ICollection<UserExam>UserExam { get; set; }
    }
}
