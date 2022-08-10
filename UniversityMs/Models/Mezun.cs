using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.Areas.UniversityMsAdmin.Models;

namespace UniversityMs.Models
{
    public class Mezun
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string LeftImg { get; set; }
        public string Image { get; set; }
        [Required]
        public string ImgTitle { get; set; }
        [Required]
        public string ImgDesc { get; set; }
        [Required]
        public string WikiLink { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Please select a file.")]
        [DataType(DataType.Upload)]
        [MaxFileSize(4 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".png" })]
        public IFormFile Photo { get; set; }
    }
}
