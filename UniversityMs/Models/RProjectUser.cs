using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class RProjectUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RProjectId { get; set; }
        public AppUser User { get; set; }
        public ResearchProjeck ResearchProjeck { get; set; }
    }
}
