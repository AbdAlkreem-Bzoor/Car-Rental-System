using AutoMapper;

namespace Car_Rental.Web.Profiles
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<Db.Entities.Car, Models.Car>();
        }
    }
}
