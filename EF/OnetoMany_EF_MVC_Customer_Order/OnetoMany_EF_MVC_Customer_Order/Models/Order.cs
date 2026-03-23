using System.ComponentModel.DataAnnotations;

namespace OnetoMany_EF_MVC_Customer_Order.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        public decimal Amount { get; set; }

        // Foreign key
        public int CustomerId { get; set; }

        // Navigation property
        public Customer Customer { get; set; }
    }
}
