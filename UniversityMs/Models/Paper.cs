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
    public class Paper
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public bool IsDaleted { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Please select a file.")]
        [DataType(DataType.Upload)]
        [MaxFileSize(4 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".png" })]
        public IFormFile Photo { get; set; }
        public ICollection<ExamPaper> ExamPaper { get; set; }
        public ICollection<RProjectPaper> RProjectPaper { get; set; }
    }
}
