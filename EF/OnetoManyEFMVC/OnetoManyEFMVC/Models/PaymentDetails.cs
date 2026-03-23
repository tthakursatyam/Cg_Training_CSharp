namespace OnetoManyEFMVC.Models
{
    public class PaymentDetails
    {
        public int Id { get; set; }

        public double Amount { get; set; }

        public string PaymentMode { get; set; }

        public int CollegeMasterId { get; set; }

        public CollegeMaster College { get; set; }
    }
}