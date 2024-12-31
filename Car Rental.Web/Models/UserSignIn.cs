using System.ComponentModel.DataAnnotations;

namespace Car_Rental.Web.Models
{
    public class UserSignIn
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
