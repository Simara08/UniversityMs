using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class ResearchTopic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TotalMark { get; set; }
        public bool IsDaleted { get; set; }
        public ICollection<RTopicUser> RTopicUser { get; set; }
    }
}
