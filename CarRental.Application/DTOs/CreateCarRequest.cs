using CarRental.Domain.Enums;
using Swashbuckle.AspNetCore.Annotations;
using System.Text.Json.Serialization;

namespace CarRental.Application.DTOs
{
    public class CreateCarRequest
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [SwaggerSchema(Description = "Tipo de coche: Premium, SUV, Small")]
        public CarType Type { get; set; }
    }
}
