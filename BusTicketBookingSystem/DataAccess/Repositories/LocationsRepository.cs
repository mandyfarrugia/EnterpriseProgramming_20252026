using DataAccess.Context;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class LocationsRepository
    {
        private BookingSystemDbContext _context { get; set; }

        public LocationsRepository(BookingSystemDbContext context)
        {
            this._context = context;
        }

        public IQueryable<Location> Get()
        {
            return this._context.Locations;
        }

        public Location? Get(Guid id)
        {
            return this.Get().SingleOrDefault(location => location.Id == id);
        }

        public Location? Get(string locationIdentifier)
        {
            return this.Get().SingleOrDefault(location => location.Name.Equals(locationIdentifier));
        }

        public void AddLocation(Location location)
        {
            this._context.Locations.Add(location);
            this._context.SaveChanges();
        }

        public void UpdateLocation(Location location)
        {
            Location? locationToUpdate = this.Get(location.Id);

            if (locationToUpdate != null)
            {
                locationToUpdate.Name = location.Name;

                this._context.SaveChanges();
            }
        }

        public void DeleteLocation(Guid id)
        {
            Location? locationToDelete = this.Get(id);

            if (locationToDelete != null)
            {
                this._context.Locations.Remove(locationToDelete);
                this._context.SaveChanges();
            }
        }
    }
}
