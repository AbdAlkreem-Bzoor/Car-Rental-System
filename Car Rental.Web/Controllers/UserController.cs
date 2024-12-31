using Car_Rental.Web.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Car_Rental.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IAppRepository _repository;
        public UserController(IAppRepository repository)
        {
            _repository = repository;
        }
        [Route("User/ListUsers")]
        public async Task<IActionResult> ListUsers()
        {
            return Ok(await _repository.GetUsersAsync());
        }
        [Route("User/ListUser/{userId}")]
        public async Task<IActionResult> ListUser(int userId)
        {
            var user = await _repository.GetUserAsync(userId);
            if (user is null)
            {
                return NotFound("The User doesn't exist");
            }
            return Ok(user);
        }
    }
}
