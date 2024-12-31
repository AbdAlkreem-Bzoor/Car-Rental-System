using Car_Rental.Web.Models;

namespace Car_Rental.Web.Repositories
{
    public interface ICarRepository
    {
        Task<Car?> GetCarAsync(int id);
        Task<IEnumerable<Car>> GetCarsAsync();
        Task<bool> AddCarAsync(Car car);
        Task<bool> DeleteCarAsync(int id);
        Task<bool> UpdateCarAsync(Car car);
    }
}
