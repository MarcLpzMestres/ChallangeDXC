using CarRental.Domain.Entities;
using CarRental.Domain.Enums;
using CarRental.Infrastructure.Interfaces;

namespace CarRental.Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly List<Car> _cars;

        public CarRepository()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, Brand = "BMW", Model = "M4", Type = CarType.Premium },
                new Car { Id = 2, Brand = "Hyundai", Model = "TUCSON", Type = CarType.SUV },
                new Car { Id = 3, Brand = "Nissan", Model = "Juke", Type = CarType.SUV },
                new Car { Id = 4, Brand = "Seat", Model = "Ibiza", Type = CarType.Small },
                new Car { Id = 5, Brand = "Mercedes", Model = "GLC Coupe", Type = CarType.Premium }
            };
        }

        public IEnumerable<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Car car)
        {
            car.Id = _cars.Max(c => c.Id) + 1;
            _cars.Add(car);
        }

    }
}
