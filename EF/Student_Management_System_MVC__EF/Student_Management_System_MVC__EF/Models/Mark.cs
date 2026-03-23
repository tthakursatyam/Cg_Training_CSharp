namespace Student_Management_System_MVC__EF.Models
{
    public class Mark
    {
        public int MarkId { get; set; }
        public int StudentId { get; set; }
        public string Subject { get; set; }
        public int Score { get; set; }
        public Student student { get; set; }
    }
}
