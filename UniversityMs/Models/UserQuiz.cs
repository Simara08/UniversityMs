using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class UserQuiz
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int QuizId { get; set; }
        public AppUser User { get; set; }
        public Quiz Quiz { get; set; }
        public int Mark { get; set; }
    }
}
