namespace GloboTicket.TicketManagement.Application.Models.Mail
{
    /// Custom model that contain the information that needs to be sent as email.
    public class Email
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
