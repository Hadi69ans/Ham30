namespace Ham30.Server.Services.Identity.Models
{
    public class Message
    {
        public string ToUserId { get; set; }
        public string FromUserId { get; set; }
        public string MessageText { get; set; }
    }
}