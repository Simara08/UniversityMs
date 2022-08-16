using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class SemOffering
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsDaleted { get; set; }
        public int UniProgramId { get; set; }
        public UniProgram UniProgram { get; set; }
        public Semestr Semestr { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public Section Section { get; set; }
        public ICollection<SemOffCourse> SemOffCourse { get; set; }

    }
}
