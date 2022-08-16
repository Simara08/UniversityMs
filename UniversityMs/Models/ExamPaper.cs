using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class ExamPaper
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public int PaperId { get; set; }
        public Exam Exam { get; set; }
        public Paper Paper { get; set; }
    }
}
