using System.ComponentModel.DataAnnotations;

namespace ConsoleApp.Entity
{
    public class Student
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string? Phone { get; set; }
    }
}