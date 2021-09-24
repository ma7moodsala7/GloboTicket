using System;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events
{
    public class GetEventDetailQuery: IRequest<EventDetailVm>
    {
        /// detect which event detail do i need to fetch
        public Guid Id { get; set; }
    }
}
