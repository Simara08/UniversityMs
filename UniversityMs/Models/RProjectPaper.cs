using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class RProjectPaper
    {
        public int Id { get; set; }
        public int PaperId { get; set; }
        public int RProjectId { get; set; }
        public Paper Paper{ get; set; }
        public ResearchProject RProject { get; set; }
    }
}
