using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class BookingSystemDbContext : IdentityDbContext
    {
        public BookingSystemDbContext(DbContextOptions<BookingSystemDbContext> options) : base(options)
        {
        }

        public DbSet<Bus> Buses { get; set; }
        public DbSet<Fleet> Fleets { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Ticket>()
                .HasOne(ticket => ticket.Origin)
                .WithMany()
                .HasForeignKey(ticket => ticket.OriginFK)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Ticket>()
                .HasOne(ticket => ticket.Destination)
                .WithMany()
                .HasForeignKey(ticket => ticket.DestinationFK)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Bus>().Property(bus => bus.Id).HasDefaultValueSql("NEWID()");
            builder.Entity<Fleet>().Property(fleet => fleet.Id).HasDefaultValueSql("NEWID()");
            builder.Entity<Line>().Property(line => line.Id).HasDefaultValueSql("NEWID()");
            builder.Entity<Location>().Property(location => location.Id).HasDefaultValueSql("NEWID()");
            builder.Entity<Ticket>().Property(ticket => ticket.Id).HasDefaultValueSql("NEWID()");
            builder.Entity<TicketType>().Property(ticketType => ticketType.Id).HasDefaultValueSql("NEWID()");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}