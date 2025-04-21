using Microsoft.Extensions.DependencyInjection;
using CarRental.Application.Interfaces;
using CarRental.Application.Services;
using CarRental.Infrastructure.Services;

namespace CarRental.Application.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IRentalService, RentalService>();
            services.AddScoped<IPriceCalculator, PriceCalculator>();
            services.AddScoped<ICarManagementService, CarManagementService>();
            services.AddSingleton<IClientService, ClientService>();
            return services;
        }
    }
}
