using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class ProjectUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public AppUser User { get; set; }
        public UniProject Project { get; set; }
    }
}
