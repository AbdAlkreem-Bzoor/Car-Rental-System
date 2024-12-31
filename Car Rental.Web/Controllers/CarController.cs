using Car_Rental.Web.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Car_Rental.Web.Controllers
{
    public class CarController : Controller
    {
        private readonly IAppRepository _repository;
        public CarController(IAppRepository repository)
        {
            _repository = repository;
        }
        [Route("Car/ListCars")]
        public async Task<IActionResult> ListCars()
        {
            return Ok(await _repository.GetCarsAsync());
        }
        [Route("Car/ListRental/{carId}")]
        public async Task<IActionResult> ListCar(int carId)
        {
            var car = await _repository.GetCarAsync(carId);
            if (car is null)
            {
                return NotFound("The Car doesn't exist");
            }
            return Ok(car);
        }
    }
}
