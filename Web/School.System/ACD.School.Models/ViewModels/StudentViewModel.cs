using System.ComponentModel.DataAnnotations;

namespace ACD.School.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(15)]
        public string? PhoneNumber { get; set; }

        public DateTime CreatedDate { get; set; }
    }

    public class StudentCreateViewModel
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(15)]
        public string? PhoneNumber { get; set; }
    }
}