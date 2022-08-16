using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class ResearchTopic
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        public int Mark { get; set; }
        public bool IsDaleted { get; set; }
        public ICollection<RTopicUser> RTopicUser { get; set; }
    }
}
