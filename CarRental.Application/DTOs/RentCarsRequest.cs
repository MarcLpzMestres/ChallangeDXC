using CarRental.Domain.Entities;

namespace CarRental.Application.DTOs
{
    public class RentCarsRequest
    {
        public int CustomerId { get; set; }
        public List<RentCarItem> CarsToRent { get; set; } = new();
    }

    public class RentCarItem
    {
        public int carId {  get; set; }
        public int Days { get; set; }
    }

}
