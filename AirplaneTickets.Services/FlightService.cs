using AirplaneTickets.Data;
using System.Linq;

public class FlightService
{
    private AppDbContext _context = new AppDbContext();

    public List<Flight> GetAll()
    {
        using (var context = new AppDbContext())
        {
            return context.Flights.ToList(); // винаги свежи данни
        }
    }

    public void Add(Flight flight)
    {
        _context.Flights.Add(flight);
        _context.SaveChanges();
    }

    public void Delete(int flightId)
    {
        using (var context = new AppDbContext())
        {
            var flight = _context.Flights.Find(flightId);
            if (flight != null)
            {
                _context.Flights.Remove(flight);
                _context.SaveChanges();
            }
        }
    }
}