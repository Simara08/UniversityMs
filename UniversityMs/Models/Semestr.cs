using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Semestr
    {
        public int Id { get; set; }
        public int SemestrNum { get; set; }
        public int SemOfferingId { get; set; }
        public SemOffering SemOffering { get; set; }
        public bool IsDaleted { get; set; }
    }
}
