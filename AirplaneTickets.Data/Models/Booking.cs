using System;
using System.ComponentModel.DataAnnotations.Schema;

public class Booking
{
    [Column("booking_id")]
    public int BookingId { get; set; }

    [Column("customer_id")]
    public int CustomerId { get; set; }

    [Column("flight_id")] 
    public int FlightId { get; set; }

    [Column("booking_date")]
    public DateTime BookingDate { get; set; }

    [Column("status")]
    public string Status { get; set; }

    public Customer Customer { get; set; }
    public Flight Flight { get; set; }
    public List<Ticket> Tickets { get; set; } = new List<Ticket>();
}