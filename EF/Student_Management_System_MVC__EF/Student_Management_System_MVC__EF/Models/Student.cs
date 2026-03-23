using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Student_Management_System_MVC__EF.Models
{
    public class Student
    {
        [Required]

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public ICollection<Mark> marks { get; set; }


    }
}
