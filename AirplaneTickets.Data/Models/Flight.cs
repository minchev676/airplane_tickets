using System;
using System.ComponentModel.DataAnnotations.Schema;

public class Flight
{
    [Column("flight_id")]
    public int FlightId { get; set; }

    [Column("origin")]
    public string Origin { get; set; }

    [Column("destination")]
    public string Destination { get; set; }

    [Column("departure_time")]
    public DateTime DepartureTime { get; set; }

    [Column("arrival_time")]
    public DateTime ArrivalTime { get; set; }

    [Column("price")]
    public decimal Price { get; set; }

    [Column("available_seats")]
    public int AvailableSeats { get; set; }
}