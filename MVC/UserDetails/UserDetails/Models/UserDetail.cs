using System.ComponentModel.DataAnnotations;
     
namespace UserDetails.Models
{
    public class UserDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(35)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(35)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(15)]
        public string Password { get; set; }
        [Required]
        public string IsActive { get; set; }
    }
}
