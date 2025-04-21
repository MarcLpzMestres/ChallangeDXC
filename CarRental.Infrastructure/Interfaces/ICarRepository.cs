using CarRental.Domain.Entities;

namespace CarRental.Infrastructure.Interfaces
{
    public interface ICarRepository
    {
        Car GetById(int id);
        IEnumerable<Car> GetAll();
        void Add(Car car);
    }
}
