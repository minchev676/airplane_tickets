using System;
using System.Linq;
using AirplaneTickets.Data;

namespace AirplaneTickets.Services
{
    public class BookingService
    {
        public void BookTicket(int customerId, int flightId, string seatNumber)
        {
            using (var context = new AppDbContext())
            {
                var flight = context.Flights.FirstOrDefault(f => f.FlightId == flightId);

                if (flight == null)
                    throw new Exception("Полетът не е намерен!");

                if (flight.AvailableSeats <= 0)
                    throw new Exception("Няма свободни места!");

                
                var booking = new Booking
                {
                    CustomerId = customerId,
                    FlightId = flightId,
                    BookingDate = flight.DepartureTime, 
                    Status = "активен",
                    Tickets = new List<Ticket>()
                };

                context.Bookings.Add(booking);
                context.SaveChanges(); 

                var ticket = new Ticket
                {
                    BookingId = booking.BookingId,
                    FlightId = flight.FlightId,
                    SeatNumber = seatNumber,
                    Price = flight.Price
                };

                context.Tickets.Add(ticket);

                // намаляваме местата
                flight.AvailableSeats--;

                context.SaveChanges();
            }
        }

        public object GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Bookings
                    .Select(b => new
                    {
                        b.BookingId,
                        Customer = b.Customer.FirstName + " " + b.Customer.LastName,
                        Flight = b.Flight.Origin + " → " + b.Flight.Destination ,
                        Seats = string.Join(", ", b.Tickets.Select(t => t.SeatNumber)),
                        b.BookingDate,
                        b.Status
                    })
                    .ToList();
            }
        }

        public void Delete(int id)
        {
            using (var context = new AppDbContext())
            {
                var booking = context.Bookings.Find(id);
                if (booking != null)
                {
                    context.Bookings.Remove(booking);
                    context.SaveChanges();
                }
            }
        }
    }
}