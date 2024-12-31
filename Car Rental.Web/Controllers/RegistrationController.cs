using Microsoft.AspNetCore.Mvc;

namespace Car_Rental.Web.Controllers
{
    public class RegistrationController : Controller
    {
        [Route("Registration/SignIn")]
        public IActionResult SignIn()
        {
            return Ok();
        }
    }
}

