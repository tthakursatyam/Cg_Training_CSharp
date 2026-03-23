namespace OnetoManyEFMVC.Models
{
    public class Hostel
    {
        public int Id { get; set; }

        public string HostelName { get; set; }

        public int CollegeMasterId { get; set; }

        public CollegeMaster College { get; set; }
    }
}