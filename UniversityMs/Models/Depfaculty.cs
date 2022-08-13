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
        [Key, Column(Order = 1)]
        public int FacultyId { get; set; }
        [Key, Column(Order = 2)]
        public int DepartmentId { get; set; }
        public Faculty Faculty { get; set; }
        public Department Department { get; set; }
    }
}
