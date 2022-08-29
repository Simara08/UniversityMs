using System.ComponentModel.DataAnnotations;

namespace UniversityMs.Areas.StudentPanel.ViewModels
{
    public class AdminLoginVM
    {
        [Required]
        [MaxLength(25)]
        [MinLength(6)]
        public string Email { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
