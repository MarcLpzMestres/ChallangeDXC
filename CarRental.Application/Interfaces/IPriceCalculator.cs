using CarRental.Application.DTOs;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces
{
    public interface IPriceCalculator
    {
        PriceResult CalculatePrice(Car car, int rentalDays);
        decimal CalculateExtraCharges(Car car, int extraDays);
    }
}
