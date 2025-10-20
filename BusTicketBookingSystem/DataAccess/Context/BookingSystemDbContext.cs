using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

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

            builder.Entity<Line>().HasData(SeedLines());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        private static List<Line> SeedLines()
        {
            var routeNumbers = new string[]
            {
                "X1A", "TD1", "TD2", "TD3", "TD4", "TD5", "117", "119", "135", "218", "71", "72", "73",
                "201", "208", "214", "N11", "N13", "N212", "N62", "N82", "N91", "N48",
                "1", "2", "3", "4", "13", "13A", "14", "15", "16", "21", "22", "24", "25", "31", "32", "35",
                "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "56", "58", "58A",
                "61", "62", "63", "64", "74", "80", "81", "82", "82A", "82B", "83", "84", "85", "88", "90", "91", 
                "92", "93", "94", "101", "103", "106", "109", "109A", "110", "120", "121", "122", "124", "130", "133",
                "181", "182", "186", "202", "203", "204", "205", "206", "207", "209", "210", "211", "212",
                "213", "221", "222", "223", "225", "226", "233", "238", "250", "260", "280", "301", "302", "303", 
                "305", "306", "307", "308", "309", "310", "311", "312", "313", "322", "323", "330",
                "TD10", "TD13", "N301", "X300", "150", "300", "X299", "401", "402", "403", "404", "405"
            };

            return routeNumbers.Select(routeNumber => new Line
            {
                Id = Guid.NewGuid(),
                Name = routeNumber
            }).ToList();
        }
    }
}