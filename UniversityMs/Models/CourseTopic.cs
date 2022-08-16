using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class CourseTopic
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public int CourseId { get; set; }
        public Topic Topic{ get; set; }
        public Course Course { get; set; }
    }
}
