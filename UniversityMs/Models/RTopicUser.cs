using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class RTopicUser
    {
        public int Id { get; set; }
        public int RTopicId { get; set; }
        public int UserId { get; set; }
        public AppUser User { get; set; }
        public ResearchTopic RTopic { get; set; }
    }
}
