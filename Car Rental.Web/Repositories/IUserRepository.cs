using Car_Rental.Web.Models;

namespace Car_Rental.Web.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetUserAsync(int id);
        Task<IEnumerable<User>> GetUsersAsync();
        Task<bool> AddUserAsync(User user);
        Task<bool> DeleteUserAsync(int id);
        Task<bool> UpdateUserAsync(User user);
    }
}
