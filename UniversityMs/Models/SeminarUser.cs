using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class SeminarUser
    {
        public int Id { get; set; }
        public int SeminarId { get; set; }
        public int UserId { get; set; }
        public Seminar Seminar { get; set; }
        public AppUser User { get; set; }
    }
}
