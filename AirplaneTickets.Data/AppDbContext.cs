using Microsoft.EntityFrameworkCore;
using AirplaneTickets.Data.Models;

namespace AirplaneTickets.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string connection = "server=localhost;port=3306;database=airplane_tickets;user=root;password=;";

            options.UseMySql(connection, ServerVersion.AutoDetect(connection));
        }
    }
}