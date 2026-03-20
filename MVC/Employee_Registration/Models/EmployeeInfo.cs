using System;
using System.ComponentModel.DataAnnotations;
namespace Employee_Registration.Models
{
    public class EmployeeInfo
    {
        public int EmpId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
