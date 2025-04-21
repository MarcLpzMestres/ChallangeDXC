using CarRental.Domain.Entities;

namespace CarRental.Infrastructure.Interfaces
{
    public interface IClientRepository
    {
        Client GetById(int id);
        IEnumerable<Client> GetAll();

        void AddPoints(int clientId, int points);
    }
}
