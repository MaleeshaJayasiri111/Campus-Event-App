namespace CampusEventAdmin.Models
{
    public class Feedbacks
    {
        public string eventId { get; set; } = "";
        public string eventTitle { get; set; } = "";
        public string submittedBy { get; set; } = "";
        public string email { get; set; } = "";
        public string comment { get; set; } = "";
        public int rating { get; set; } = 5;
    }
}