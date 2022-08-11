using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Partner
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Required]
        public string SvgIcon { get; set; }
    }
}
