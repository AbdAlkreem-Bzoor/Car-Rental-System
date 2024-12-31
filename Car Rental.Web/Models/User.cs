using Car_Rental.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Car_Rental.Web.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public Cities City { get; set; }
        public Countries Country { get; set; }
        public string DriversLicenseNumber { get; set; } = null!;
    }
}
