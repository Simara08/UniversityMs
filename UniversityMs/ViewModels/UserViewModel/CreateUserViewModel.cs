﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.ViewModels.UserViewModel
{
    public class CreateUserViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                           ErrorMessage = "Email adresi geçersiz")]
        public string Email { get; set; }

        [Required]
        public string Adress { get; set; }
        [Required]
        public string PhoneNum { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string DateofBirth { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords does not matching.")]
        public string ConfirmPassword { get; set; }

        public string ProfileImage { get; set; }
    }
}
