using DataAccess.Context;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class TicketTypesRepository
    {
        private BookingSystemDbContext _context { get; set; }

        public TicketTypesRepository(BookingSystemDbContext context)
        {
            this._context = context;
        }

        public IQueryable<TicketType> Get()
        {
            return this._context.TicketTypes;
        }

        public TicketType? Get(Guid id)
        {
            return this.Get().SingleOrDefault(ticketType => ticketType.Id == id);
        }

        public TicketType? Get(string ticketTypeIdentifier)
        {
            return this.Get().SingleOrDefault(ticketType => ticketType.Name.Equals(ticketTypeIdentifier));
        }

        public void AddTicketType(TicketType ticketType)
        {
            this._context.TicketTypes.Add(ticketType);
            this._context.SaveChanges();
        }

        public void UpdateTicketType(TicketType ticketType)
        {
            TicketType? ticketTypeToUpdate = this.Get(ticketType.Id);

            if (ticketTypeToUpdate != null)
            {
                ticketTypeToUpdate.Name = ticketType.Name;
                ticketTypeToUpdate.Cost = ticketType.Cost;

                this._context.SaveChanges();
            }
        }

        public void DeleteTicketType(Guid id)
        {
            TicketType? ticketTypeToDelete = this.Get(id);

            if (ticketTypeToDelete != null)
            {
                this._context.TicketTypes.Remove(ticketTypeToDelete);
                this._context.SaveChanges();
            }
        }
    }
}
