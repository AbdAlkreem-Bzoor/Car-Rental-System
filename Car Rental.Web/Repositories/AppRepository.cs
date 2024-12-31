using AutoMapper;
using Car_Rental.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_Rental.Web.Repositories
{
    public class AppRepository : IAppRepository
    {
        private readonly Db.Data.AppDbContext _database;
        private readonly ILogger<AppRepository> _logger;
        private readonly IMapper _mapper;
        public AppRepository(Db.Data.AppDbContext database, ILogger<AppRepository> logger, IMapper mapper)
        {
            _database = database;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<bool> AddCarAsync(Car car)
        {
            if (await _database.Cars.Include(x => x.Rentals).AnyAsync(x => x.Id == car.Id))
            {
                _logger.LogInformation($"Car already exist {car}");
                return false;
            }
            await _database.Cars.AddAsync(_mapper.Map<Db.Entities.Car>(car));
            return true;
        }

        public async Task<bool> AddRentalAsync(Rental rental)
        {
            if (await _database.Rentals.Include(x => x.Car).Include(x => x.User).AnyAsync(x => x.Id == rental.Id))
            {
                _logger.LogInformation($"Rental already exist {rental}");
                return false;
            }
            await _database.Rentals.AddAsync(_mapper.Map<Db.Entities.Rental>(rental));
            return true;
        }

        public async Task<bool> AddUserAsync(User user)
        {
            if (await _database.Users.Include(x => x.Rentals).AnyAsync(x => x.Id == user.Id))
            {
                _logger.LogInformation($"User already exist {user}");
                return false;
            }
            await _database.Users.AddAsync(_mapper.Map<Db.Entities.User>(user));
            return true;
        }

        public async Task<bool> DeleteCarAsync(int id)
        {
            var car = await _database.Cars.Include(x => x.Rentals).FirstOrDefaultAsync(x => x.Id == id);
            if (car is null)
            {
                _logger.LogInformation($"Car doesn't exist with id: [{id}]");
                return false;
            }
            _database.Cars.Remove(car);
            return true;
        }

        public async Task<bool> DeleteRentalAsync(int id)
        {
            var rental = await _database.Rentals.Include(x => x.Car).Include(x => x.User).FirstOrDefaultAsync(x => x.Id == id);
            if (rental is null)
            {
                _logger.LogInformation($"Rental doesn't exist with id: [{id}]");
                return false;
            }
            _database.Rentals.Remove(rental);
            return true;
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var user = await _database.Users.Include(x => x.Rentals).FirstOrDefaultAsync(x => x.Id == id);
            if (user is null)
            {
                _logger.LogInformation($"User doesn't exist with id: [{id}]");
                return false;
            }
            _database.Users.Remove(user);
            return true;
        }

        public async Task<Car?> GetCarAsync(int id)
        {
            return _mapper.Map<Car?>(await _database.Cars.Include(x => x.Rentals).FirstOrDefaultAsync(x => x.Id == id));
        }

        public async Task<IEnumerable<Car>> GetCarsAsync()
        {
            return _mapper.Map<IEnumerable<Car>>(await _database.Cars.Include(x => x.Rentals).ToListAsync());
        }

        public async Task<Rental?> GetRentalAsync(int id)
        {
            return _mapper.Map<Rental?>(await _database.Rentals.Include(x => x.Car).Include(x => x.User).FirstOrDefaultAsync(x => x.Id == id));
        }

        public async Task<IEnumerable<Rental>> GetRentalsAsync()
        {
            return _mapper.Map<IEnumerable<Rental>>(await _database.Rentals.Include(x => x.Car).Include(x => x.User).ToListAsync());
        }

        public async Task<User?> GetUserAsync(int id)
        {
            return _mapper.Map<User?>(await _database.Users.Include(x => x.Rentals).FirstOrDefaultAsync(x => x.Id == id));
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return _mapper.Map<IEnumerable<User>>(await _database.Users.Include(x => x.Rentals).ToListAsync());
        }
        public async Task<bool> UpdateCarAsync(Car car)
        {
            var databaseCar = await _database.Cars.Include(x => x.Rentals).FirstOrDefaultAsync(x => x.Id == car.Id);
            if (databaseCar is null)
            {
                _logger.LogInformation($"Car doesn't exist with id: [\n\r{car}\r\n]");
                return false;
            }

            databaseCar.Manufacturer = car.Manufacturer;
            databaseCar.Model = car.Model;
            databaseCar.LicensePlate = car.LicensePlate;
            databaseCar.Color = car.Color;
            databaseCar.DailyRate = car.DailyRate;
            databaseCar.Type = _mapper.Map<Db.Entities.CarType>(car.Type);
            databaseCar.Year = car.Year;
            databaseCar.IsAvailable = car.IsAvailable;

            return true;
        }

        public async Task<bool> UpdateRentalAsync(Rental rental)
        {
            var databaseRental = await _database.Rentals.Include(x => x.Car).Include(x => x.User).FirstOrDefaultAsync(x => x.Id == rental.Id);
            if (databaseRental is null)
            {
                _logger.LogInformation($"Rental doesn't exist with id: [\n\r{rental}\r\n]");
                return false;
            }

            databaseRental.TotalAmount = rental.TotalAmount;
            databaseRental.Status = _mapper.Map<Db.Entities.RentalStatus>(rental.Status);
            databaseRental.StartDate = rental.StartDate;
            databaseRental.EndDate = rental.EndDate;
            databaseRental.Car = _mapper.Map<Db.Entities.Car>(rental.Car);
            databaseRental.User = _mapper.Map<Db.Entities.User>(rental.User);

            return true;
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            var databaseUser = await _database.Users.Include(x => x.Rentals).FirstOrDefaultAsync(x => x.Id == user.Id);
            if (databaseUser is null)
            {
                _logger.LogInformation($"Rental doesn't exist with id: [\n\r{user}\r\n]");
                return false;
            }

            databaseUser.FirstName = user.FirstName;
            databaseUser.LastName = user.LastName;
            databaseUser.Email = user.Email;
            databaseUser.Password = user.Password;
            databaseUser.AddressLine1 = user.AddressLine1;
            databaseUser.AddressLine2 = user.AddressLine2;
            databaseUser.DriversLicenseNumber = user.DriversLicenseNumber;
            databaseUser.PhoneNumber = user.PhoneNumber;
            databaseUser.City = _mapper.Map<Db.Entities.Cities>(user.City);
            databaseUser.Country = _mapper.Map<Db.Entities.Countries>(user.Country);
            databaseUser.DateOfBirth = user.DateOfBirth;

            return true;
        }
    }
}
