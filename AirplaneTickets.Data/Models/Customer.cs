using System.ComponentModel.DataAnnotations.Schema;

public class Customer
{
    [Column("customer_id")]
    public int CustomerId { get; set; }

    [Column("first_name")]
    public string FirstName { get; set; }

    [Column("last_name")]
    public string LastName { get; set; }

    [Column("email")]
    public string Email { get; set; }

    [Column("phone")]
    public string Phone { get; set; }
}