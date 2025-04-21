namespace CarRental.Domain.ValueObjects;

public class ReturnRequest
{
    public int CarId { get; set; }
    public int ExtraDays { get; set; }
}
