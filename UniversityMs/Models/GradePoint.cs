using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class GradePoint
    {
        public int Id { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public string GradePoints { get; set; }
        public bool IsDaleted { get; set; }
    }
}
