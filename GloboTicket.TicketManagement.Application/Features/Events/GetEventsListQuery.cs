using System.Collections.Generic;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events
{
    // Make this class a message by letting it implement the IRequest interface.
    // The type parameter, that is for IRequest is going to be the type of data that this query is going to be getting back

    // this is inter-object communication, so that will be a message.

    /// <summary>
    /// Wrapping all events in a list in an object "message",
    /// return the list of all events in GloboTicket.
    /// </summary>
    public class GetEventsListQuery : IRequest<List<EventListVm>>
    {
    }
}
