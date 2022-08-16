using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Seminar
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int Mark { get; set; }
        public bool IsDaleted { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public int UserId { get; set; }
        public AppUser User { get; set; }
    }
}
