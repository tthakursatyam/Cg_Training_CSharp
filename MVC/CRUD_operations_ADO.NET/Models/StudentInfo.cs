using System.ComponentModel.DataAnnotations;

namespace CRUD_operations_ADO.NET.Models
{
    public class StudentInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required\n")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required\n")]
        [Range(1, 120, ErrorMessage = "Enter valid age\n")]
        public int Age { get; set; }

        [Required(ErrorMessage = "City is required\n")]
        public string City { get; set; }

        [Required(ErrorMessage = "Father name is required\n")]
        public string Fathername { get; set; }

        [Required(ErrorMessage = "Email is required\n")]
        [EmailAddress(ErrorMessage = "Invalid Email Format\n")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile number is required\n")]
        [RegularExpression(@"^[0-9]{10}$",
            ErrorMessage = "Enter valid 10 digit number\n")]
        public string Number { get; set; }

        public string? ImagePath { get; set; }
    }
}