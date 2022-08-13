using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class DepUser
    {
        public int AppUserId { get; set; }
        public int DepId { get; set; }
        public int ProgramId { get; set; }
        public AppUser  User { get; set; }
        public Department Dep { get; set; }
        public Program Program { get; set; }
    }
}
