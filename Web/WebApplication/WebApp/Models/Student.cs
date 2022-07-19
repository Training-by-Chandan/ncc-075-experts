using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }

        public int ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Standards Standard { get; set; }
    }

    public class Standards
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}