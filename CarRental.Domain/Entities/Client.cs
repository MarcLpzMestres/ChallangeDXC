namespace CarRental.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int LoyaltyPoints { get; set; } = 0;
    }
}
