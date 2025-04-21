using CarRental.Infrastructure.Interfaces;
using CarRental.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            // Inyecto dependencias singleton para mantener en memoria los datos virtuales de coches y clientes
            services.AddSingleton<ICarRepository, CarRepository>();
            services.AddSingleton<IClientRepository, ClientRepository>();
            return services;
        }
    }
}
