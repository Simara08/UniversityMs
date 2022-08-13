using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class AppUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string ProfileImage { get; set; }    
        public string PhoneNum { get; set; }    
        public string Adress { get; set; }    
        public DateTime DateofBirth { get; set; }    
        public bool IsActivated { get; set; }
        public ICollection<UserExam> UserExam { get; set; }
        public ICollection<DepUser> DepUsers { get; set; }
    }
}
