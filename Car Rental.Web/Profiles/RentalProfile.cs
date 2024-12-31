using AutoMapper;

namespace Car_Rental.Web.Profiles
{
    public class RentalProfile : Profile
    {
        public RentalProfile()
        {
            CreateMap<Db.Entities.Rental, Models.Rental>();
        }
    }
}
