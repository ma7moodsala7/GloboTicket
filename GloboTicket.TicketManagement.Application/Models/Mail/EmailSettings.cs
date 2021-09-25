namespace GloboTicket.TicketManagement.Application.Models.Mail
{
    /// A custom model that contains properties that i'm going to read from appSettings file,
    /// to configure my external email service, which will be SendGrid
    public class EmailSettings
    {
        public string ApiKey { get; set; }
        public string FromAddress { get; set; }
        public string FromName { get; set; }
    }
}
