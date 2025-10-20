using DataAccess.Context;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class LinesRepository
    {
        private BookingSystemDbContext _context;

        public LinesRepository(BookingSystemDbContext context)
        {
            this._context = context;
        }

        public IQueryable<Line> Get() 
        {
            return this._context.Lines;
        }

        public Line? Get(Guid id)
        {
            return this.Get().SingleOrDefault(line => line.Id == id);
        }

        public Line? Get(string routeIdentifier)
        {
            return this.Get().SingleOrDefault(line => line.Name.Equals(routeIdentifier));
        }

        public void AddLine(Line line) 
        {
            this._context.Lines.Add(line);
            this._context.SaveChanges();
        }

        public void UpdateLine(Line line) 
        {
            Line? lineToUpdate = this.Get(line.Id);

            if(lineToUpdate != null)
            {
                lineToUpdate.Name = line.Name;
                this._context.SaveChanges();
            }
        }

        public void DeleteLine(Guid id) 
        {
            Line? lineToDelete = this.Get(id);

            if(lineToDelete != null)
            {
                this._context.Lines.Remove(lineToDelete);
                this._context.SaveChanges();
            }
        }
    }
}