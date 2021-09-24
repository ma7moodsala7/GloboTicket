using MediatR;
using System;

namespace GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail
{
    public class GetEventDetailQuery: IRequest<EventDetailVm>
    {
        /// detect which event detail do i need to fetch
        public Guid Id { get; set; }
    }
}
