using CarRental.Application.DTOs;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces
{
    public interface ICarManagementService
    {
        void AddCar(CreateCarRequest request);
        IEnumerable<Car> GetAllCars();
    }
}
