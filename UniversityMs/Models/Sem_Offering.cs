using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Sem_Offering
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Semestr Semestr { get; set; }
        public Department Department { get; set; }
        public Program Program { get; set; }

    }
}
