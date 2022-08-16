using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class DocErize
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Desc { get; set; }
        public DateTime Datetime { get; set; }
        public AppUser User { get; set; }
        public bool IsDaleted { get; set; }
    }
}
