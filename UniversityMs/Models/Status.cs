using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Statuss { get; set; }
        public bool IsDaleted { get; set; }
        public ICollection<UserSectionCourseStruc> UserSectionCourseStruc { get; set; }
    }
}
