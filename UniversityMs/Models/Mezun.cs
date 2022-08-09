using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Mezun
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string LeftImg { get; set; }
        public string Image { get; set; }
        public string ImgTitle { get; set; }
        public string ImgDesc { get; set; }
        public string WikiLink { get; set; }
        [NotMapped, Required]
        public IFormFile Photo { get; set; }
    }
}
