using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces
{
    public interface IClientService
    {
        Client? GetById(int id);
        void AddPoints(int customerId, int points);
        IEnumerable<Client> GetAll();
    }
}
