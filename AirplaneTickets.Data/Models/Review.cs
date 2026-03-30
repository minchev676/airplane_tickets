using System.ComponentModel.DataAnnotations.Schema;

public class Review
{
    [Column("review_id")]
    public int ReviewId { get; set; }

    [Column("flight_id")]
    public int FlightId { get; set; }

    [Column("customer_id")]
    public int CustomerId { get; set; }

    [Column("rating")]
    public int Rating { get; set; }

    [Column("comment")]
    public string Comment { get; set; }
}