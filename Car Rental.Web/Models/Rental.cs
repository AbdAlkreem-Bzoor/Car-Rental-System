

namespace Car_Rental.Web.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; } = null!;
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalAmount { get; set; }
        public RentalStatus Status { get; set; }
    }
}
