using Domain.Models;

namespace Presentation.Models.ViewModels
{
    public class TicketCreateViewModel
    {
        public Ticket Ticket { get; set; }
        public List<TicketType> TicketTypes { get; set; }
        public List<Line> Lines { get; set; }
        public List<Location> Origins { get; set; }
        public List<Location> Destinations { get; set; }
        public List<Bus> Buses { get; set; }
    }
}