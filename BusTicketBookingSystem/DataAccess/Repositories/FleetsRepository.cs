using DataAccess.Context;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class FleetsRepository
    {
        private BookingSystemDbContext _context { get; set; }

        public FleetsRepository(BookingSystemDbContext context)
        {
            this._context = context;
        }

        public IQueryable<Fleet> Get()
        {
            return this._context.Fleets;
        }

        public IQueryable<Fleet> GetFleetsByName(string fleetIdentifier)
        {
            return this.Get().Where(fleet => fleet.Name.Contains(fleetIdentifier));
        }

        public Fleet? Get(Guid id)
        {
            return this.Get().SingleOrDefault(fleet => fleet.Id == id);
        }

        public Fleet? Get(string fleetIdentifier)
        {
            return this.Get().SingleOrDefault(fleet => fleet.Name.Equals(fleetIdentifier));
        }

        public void AddFleet(Fleet Fleet)
        {
            this._context.Fleets.Add(Fleet);
            this._context.SaveChanges();
        }

        public void UpdateFleet(Fleet fleet)
        {
            Fleet? fleetToUpdate = this.Get(fleet.Id);

            if (fleetToUpdate != null)
            {
                fleetToUpdate.YearBuilt = fleet.YearBuilt;
                fleetToUpdate.Name = fleet.Name;
                fleetToUpdate.ImagePath = fleet.ImagePath;

                this._context.SaveChanges();
            }
        }

        public void DeleteFleet(Guid id)
        {
            Fleet? fleetToDelete = this.Get(id);

            if (fleetToDelete != null)
            {
                this._context.Fleets.Remove(fleetToDelete);
                this._context.SaveChanges();
            }
        }
    }
}
