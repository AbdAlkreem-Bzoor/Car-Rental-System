using AutoMapper;

namespace Car_Rental.Web.Profiles
{
    public class CarTypeProfile : Profile
    {
        public CarTypeProfile()
        {
            CreateMap<Db.Entities.CarType, Models.CarType>();
        }
    }
}
