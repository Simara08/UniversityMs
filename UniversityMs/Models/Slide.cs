using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Models
{
    public class Slide
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Imagetitle { get; set; }
        public string ImgDesctrip { get; set; }
        [NotMapped, Required]
        public IFormFile Photo { get; set; }
    }
}
