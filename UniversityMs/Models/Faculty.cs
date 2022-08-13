using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Depfaculty> Depfaculty { get; set; }
    }
}
