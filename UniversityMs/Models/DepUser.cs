using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class DepUser
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public int DepId { get; set; }
        public int UniProgramId { get; set; }
        public AppUser  User { get; set; }
        public Department Dep { get; set; }
        public UniProgram UniProgram { get; set; }
    }
}
