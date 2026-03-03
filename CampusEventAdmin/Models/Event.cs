namespace CampusEventAdmin.Models
{
    public class Event
    {
        public string id { get; set; } = "";
        public string title { get; set; } = "";
        public string description { get; set; } = "";
        public string location { get; set; } = "";
        public string date { get; set; } = "";
        public string time { get; set; } = "";
        public string organizedBy { get; set; } = "";
        public string poster { get; set; } = "";
    }
}