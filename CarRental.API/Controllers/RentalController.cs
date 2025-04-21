using Microsoft.AspNetCore.Mvc;
using CarRental.Application.Interfaces;
using CarRental.Application.DTOs;
using CarRental.Application.Services;

namespace CarRental.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarRentalController : ControllerBase
    {
        private readonly IRentalService _rentalService;
        private readonly ICarManagementService _carService;
        private readonly IClientService _clientService;

        public CarRentalController(IRentalService rentalService, ICarManagementService carService, IClientService clientService)
        {
            _rentalService = rentalService;
            _carService = carService;
            _clientService = clientService;
        }


        #region CARs RENTING
        [HttpPost("rent/rent")]
        public ActionResult<RentCarsResult> RentCars([FromBody] RentCarsRequest request)
        {
            var result = _rentalService.RentCars(request);
            return Ok(result);
        }
        [HttpPost("rent/return")]
        public IActionResult ReturnCar(int carId, int extraDays)
        {
            var charge = _rentalService.ReturnCar(carId, extraDays);
            return Ok(new { ExtraCharge = charge });
        }

        [HttpPost("cars/insert")]
        public IActionResult AddCar([FromBody] CreateCarRequest request)
        {
            _carService.AddCar(request);
            return Ok("Car added successfully.");
        }

        [HttpGet("cars/getAll")]
        public IActionResult GetAll()
        {
            var cars = _carService.GetAllCars();
            return Ok(cars);
        }

        #endregion

        #region CLIENTS
        [HttpGet("clients/{id}/loyalty")]
        public IActionResult GetLoyaltyPoints(int id)
        {
            var customer = _clientService.GetById(id);
            if (customer == null) return NotFound("Cliente no encontrado.");

            return Ok(new { customer.Name, customer.LoyaltyPoints });
        }

        [HttpGet("clients/getAll")]
        public IActionResult GetClients()
        {
            var customers = _clientService.GetAll();
            return Ok(customers);
        }

        #endregion


    }
}