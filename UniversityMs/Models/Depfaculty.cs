using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Depfaculty
    {
        public int Id { get; set; }
        public int FacultyId { get; set; }
        public int DepartmentId { get; set; }
        public int UniProgramId { get; set; }
        public UniProgram UniProgram { get; set; }
        public Faculty Faculty { get; set; }
        public Department Department { get; set; }
    }
}
