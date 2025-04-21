using Swashbuckle.AspNetCore.Annotations;

namespace CarRental.Domain.Enums
{
    /// <summary>
    /// Tipo de coche: Premium, SUV, Small.
    /// </summary>
    [SwaggerSchema(Description = "Tipos de coches disponibles: Premium, SUV, Small")]
    public enum CarType
    {
        /// <summary>
        /// Coche de lujo premium.
        /// </summary>
        Premium,

        /// <summary>
        /// Coche tipo SUV.
        /// </summary>
        SUV,

        /// <summary>
        /// Coche pequeño.
        /// </summary>
        Small
    }
}
