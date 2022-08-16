using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class SemOffCourse
    {
        public int Id { get; set; }
        public int SemOfferingId { get; set; }
        public int CourseId { get; set; }
        public SemOffering SemOffering { get; set; }
        public Course Course { get; set; }
    }
}
