namespace OnetoManyEFMVC.Models
{
    public class CollegeMaster
    {
        public int Id { get; set; }

        public string CollegeName { get; set; }

        public string City { get; set; }

        public List<Hostel> Hostels { get; set; }

        public List<PaymentDetails> Payments { get; set; }
    }
}