using CarRental.Application.DTOs;
using CarRental.Application.Interfaces;
using CarRental.Domain.Enums;
using CarRental.Infrastructure.Interfaces;

namespace CarRental.Application.Services
{
    public class RentalService : IRentalService
    {
        private readonly ICarRepository _carRepository;
        private readonly IPriceCalculator _priceCalculator;
        private readonly IClientService _clientService;

        public RentalService(ICarRepository carRepository,IPriceCalculator priceCalculator,IClientService customerService)
        {
            _carRepository = carRepository;
            _priceCalculator = priceCalculator;
            _clientService = customerService;
        }

        public decimal ReturnCar(int carId, int extraDays)
        {
            var car = _carRepository.GetById(carId);
            if (car == null)
                throw new Exception("Car not found");

            return _priceCalculator.CalculateExtraCharges(car, extraDays);
        }

        public RentCarsResult RentCars(RentCarsRequest request)
        {
            decimal totalPrice = 0;
            int totalPoints = 0;

            foreach (var item in request.CarsToRent)
            {
                var car = _carRepository.GetById(item.carId);
                if (car == null)
                    throw new Exception("Car not found");
                var result = _priceCalculator.CalculatePrice(car, item.Days);

                totalPrice += result.TotalPrice;
                totalPoints += result.LoyaltyPointsEarned;

                _clientService.AddPoints(request.CustomerId, result.LoyaltyPointsEarned);
            }

            return new RentCarsResult
            {
                TotalPrice = totalPrice,
                TotalLoyaltyPoints = totalPoints
            };
        }


    }
}
