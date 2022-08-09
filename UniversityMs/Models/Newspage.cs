using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Newspage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Newstitle { get; set; }
        public string Desc { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        
        [NotMapped, Required]
        public IFormFile Photo { get; set; }
    }
}
