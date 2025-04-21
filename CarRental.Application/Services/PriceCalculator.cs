using CarRental.Application.DTOs;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using CarRental.Domain.Enums;

namespace CarRental.Infrastructure.Services
{
    public class PriceCalculator : IPriceCalculator
    {
        private const decimal PremiumPrice = 300m;
        private const decimal SuvPrice = 150m;
        private const decimal SmallPrice = 50m;

        public PriceResult CalculatePrice(Car car, int rentalDays)
        {
            decimal total = 0;
            int points = 0;

            switch (car.Type)
            {
                case CarType.Premium:
                    total = PremiumPrice * rentalDays;
                    points = 5;
                    break;

                case CarType.SUV:
                    if (rentalDays <= 7)
                        total = SuvPrice * rentalDays;
                    else if (rentalDays <= 30)
                        total = SuvPrice * 7 + (rentalDays - 7) * SuvPrice * 0.8m;
                    else
                        total = SuvPrice * 7 + 23 * SuvPrice * 0.8m + (rentalDays - 30) * SuvPrice * 0.5m;
                    points = 3;
                    break;

                case CarType.Small:
                    if (rentalDays <= 7)
                        total = SmallPrice * rentalDays;
                    else
                        total = SmallPrice * 7 + (rentalDays - 7) * SmallPrice * 0.6m;
                    points = 1;
                    break;
            }

            return new PriceResult
            {
                TotalPrice = total,
                LoyaltyPointsEarned = points
            };
        }

        public decimal CalculateExtraCharges(Car car, int extraDays)
        {
            return car.Type switch
            {
                CarType.Premium => extraDays * (PremiumPrice * 1.2m),
                CarType.SUV => extraDays * (SuvPrice + SmallPrice * 0.6m),
                CarType.Small => extraDays * (SmallPrice * 1.3m),
                _ => 0
            };
        }
    }
}
