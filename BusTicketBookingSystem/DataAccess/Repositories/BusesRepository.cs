using DataAccess.Context;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class BusesRepository
    {
        private BookingSystemDbContext _context { get; set; }

        public BusesRepository(BookingSystemDbContext context)
        {
            this._context = context;
        }

        public IQueryable<Bus> Get()
        {
            return this._context.Buses;
        }

        public Bus? Get(Guid id)
        {
            return this.Get().SingleOrDefault(bus => bus.Id == id);
        }

        public Bus? Get(string plate)
        {
            return this.Get().SingleOrDefault(bus => bus.Plate.Equals(plate));
        }

        public void AddBus(Bus bus)
        {
            this._context.Buses.Add(bus);
            this._context.SaveChanges();
        }

        public void UpdateBus(Bus bus)
        {
            Bus? busToUpdate = this.Get(bus.Id);

            if (busToUpdate != null)
            {
                busToUpdate.Plate = bus.Plate;
                busToUpdate.FleetFK = bus.FleetFK;

                this._context.SaveChanges();
            }
        }

        public void DeleteBus(Guid id)
        {
            Bus? busToDelete = this.Get(id);

            if (busToDelete != null)
            {
                this._context.Buses.Remove(busToDelete);
                this._context.SaveChanges();
            }
        }
    }
}
