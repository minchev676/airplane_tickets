using System.ComponentModel.DataAnnotations.Schema;

public class Ticket
{
    [Column("ticket_id")]
    public int TicketId { get; set; }

    [Column("booking_id")]
    public int BookingId { get; set; }

    [Column("flight_id")]
    public int FlightId { get; set; }

    [Column("seat_number")]
    public string SeatNumber { get; set; }

    [Column("price")]
    public decimal Price { get; set; }

    public Booking Booking { get; set; }
    public Flight Flight { get; set; }
}