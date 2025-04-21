using CarRental.Application.DTOs;

namespace CarRental.Application.Interfaces
{
    public interface IRentalService
    {
        decimal ReturnCar(int carId, int extraDays);
        RentCarsResult RentCars(RentCarsRequest request);

    }
}
