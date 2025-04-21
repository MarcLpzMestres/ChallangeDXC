using CarRental.Application.DTOs;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using CarRental.Infrastructure.Interfaces;

namespace CarRental.Application.Services
{
    public class CarManagementService : ICarManagementService
    {
        private readonly ICarRepository _carRepository;

        public CarManagementService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void AddCar(CreateCarRequest request)
        {
            var car = new Car
            {
                Brand = request.Brand,
                Model = request.Model,
                Type = request.Type
            };

            _carRepository.Add(car);
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _carRepository.GetAll();
        }
    }
}
