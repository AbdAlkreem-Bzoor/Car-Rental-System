using Car_Rental.Web.Models;

namespace Car_Rental.Web.Repositories
{
    public interface IRentalRepository
    {
        Task<Rental?> GetRentalAsync(int id);
        Task<IEnumerable<Rental>> GetRentalsAsync();
        Task<bool> AddRentalAsync(Rental rental);
        Task<bool> DeleteRentalAsync(int id);
        Task<bool> UpdateRentalAsync(Rental rental);
    }
}
