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
    public class Newspage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Required]
        public string Newstitle { get; set; }
        [Required]
        public string Desc { get; set; }
        [Required]
        public string Content { get; set; }
        public string Image { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Please select a file.")]
        [DataType(DataType.Upload)]
        [MaxFileSize(4 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".png" })]
        public IFormFile Photo { get; set; }
    }
}
