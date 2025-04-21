using CarRental.Domain.Enums;
using System.Text.Json.Serialization;

namespace CarRental.Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CarType Type { get; set; }
    }
}
