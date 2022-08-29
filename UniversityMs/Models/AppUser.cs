using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class AppUser: IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        public bool IsAdmin { get; set; }
        [Required]
        public string LastName { get; set; }
        public string ProfileImage { get; set; }
        [Required]
        public string PhoneNum { get; set; }
        [Required]
        public string Adress { get; set; }    
        public string DateofBirth { get; set; }  
        public bool IsDeleted { get; set; }
        //public int ClassesId { get; set; }
        //public Class Classes { get; set; }
        public ICollection<UserExam> UserExam { get; set; }
        public ICollection<DepUser> DepUsers { get; set; }
        public ICollection<UserSectionCourseStruc> UserSectionCourseStruc { get; set; }
        public ICollection<UserQuiz> UserQuize { get; set; }
        public ICollection<Grade> Grade { get; set; }
        public ICollection<RTopicUser> RTopicUser { get; set; }
        public ICollection<RProjectUser> RProjectUser { get; set; }
        public ICollection<ProjectUser> ProjectUser { get; set; }
        public ICollection<AssigmentUser> AssigmentUser { get; set; }
    }
}
