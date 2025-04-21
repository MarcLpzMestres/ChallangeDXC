namespace CarRental.Domain.ValueObjects;

public class RentRequest
{
    public int CustomerId { get; set; }
    public int CarId { get; set; }
    public int Days { get; set; }
}
