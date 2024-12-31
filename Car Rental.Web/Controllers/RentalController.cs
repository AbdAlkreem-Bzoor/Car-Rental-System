using Car_Rental.Web.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Car_Rental.Web.Controllers
{
    public class RentalController : Controller
    {
        private readonly IAppRepository _repository;
        public RentalController(IAppRepository repository)
        {
            _repository = repository;
        }
        [Route("Rental/ListRentals")]
        public async Task<IActionResult> ListRentals()
        {
            return Ok(await _repository.GetRentalsAsync());
        }
        [Route("Rental/ListRental/{rentalId}")]
        public async Task<IActionResult> ListRental(int rentalId)
        {
            var rental = await _repository.GetRentalAsync(rentalId);
            if(rental is null)
            {
                return NotFound("The Rental doesn't exist");
            }
            return Ok(rental);
        }
    }
}
