using System;

namespace GloboTicket.TicketManagement.Domain.Common
{
    /// <summary>
    /// Base entity that contain a couple of base properties.
    /// </summary>
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
