﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Googlemap
    {
        public int Id { get; set; }
        [Required]
        public string Link { get; set; }
        [Required]
        public string ViewLink { get; set; }
    }
}
