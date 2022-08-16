using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class AssigmentUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AssigmentId { get; set; }
        public AppUser User { get; set; }
        public Assigment Assigment { get; set; }
        public int Mark { get; set; }
        public bool IsDaleted { get; set; }
    }
}
