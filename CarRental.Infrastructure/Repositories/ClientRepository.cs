using CarRental.Domain.Entities;
using CarRental.Infrastructure.Interfaces;

namespace CarRental.Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly List<Client> _clients = new();

        public ClientRepository()
        {
            _clients = new List<Client>
            {
                new Client { Id = 1, Name = "Marc", LoyaltyPoints = 0 },
                new Client { Id = 2, Name = "Alex", LoyaltyPoints = 0 },
                new Client { Id = 3, Name = "David", LoyaltyPoints = 0 }
            };
        }

        public void AddPoints(int clientId, int points)
        {
            var client = GetById(clientId);
            if (client != null)
            {
                client.LoyaltyPoints += points;
            }
        }

        public IEnumerable<Client> GetAll()
        {
            return _clients;
        }

        public Client GetById(int id)
        {
            return _clients.FirstOrDefault(c => c.Id == id);
        }

    }
}
