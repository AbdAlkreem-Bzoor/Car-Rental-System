using AutoMapper;

namespace Car_Rental.Web.Profiles
{
    public class CitiesStatusProfile : Profile
    {
        public CitiesStatusProfile()
        {
            CreateMap<Db.Entities.Cities, Models.Cities>();
        }
    }
}
