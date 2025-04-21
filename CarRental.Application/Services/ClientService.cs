using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;
using CarRental.Infrastructure.Interfaces;

namespace CarRental.Infrastructure.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public Client? GetById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public void AddPoints(int customerId, int points)
        {
            _clientRepository.AddPoints(customerId, points);
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }
    }
}
