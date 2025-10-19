using DataAccess.Context;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class TicketsRepository
    {
        private BookingSystemDbContext _context { get; set; }

        public TicketsRepository(BookingSystemDbContext context)
        {
            this._context = context;
        }

        public IQueryable<Ticket> Get()
        {
            return this._context.Tickets;
        }

        public Ticket? Get(string referenceNumber) 
        {
            return this.Get().SingleOrDefault(ticket => ticket.ReferenceNumber.Equals(referenceNumber));
        }

        public void AddTicket(Ticket ticket) 
        {
            this._context.Tickets.Add(ticket);
            this._context.SaveChanges();
        }

        public void UpdateTicket(Ticket ticket) 
        {
            Ticket? ticketToUpdate = this.Get(ticket.ReferenceNumber);

            if(ticketToUpdate != null)
            {
                ticketToUpdate.BusFK = ticket.BusFK;
                ticketToUpdate.DestinationFK = ticket.DestinationFK;
                ticketToUpdate.IssueDate = ticket.IssueDate;
                ticketToUpdate.Line = ticket.Line;
                ticketToUpdate.OriginFK = ticket.OriginFK;
                ticketToUpdate.ReferenceNumber = ticket.ReferenceNumber;
                ticketToUpdate.TicketTypeFK = ticket.TicketTypeFK;

                this._context.SaveChanges();
            }
        }

        public void DeleteTicket(string referenceNumber) 
        {
            Ticket? ticketToDelete = this.Get(referenceNumber);
            
            if(ticketToDelete != null)
            {
                this._context.Tickets.Remove(ticketToDelete);
                this._context.SaveChanges();
            }
        }
    }
}