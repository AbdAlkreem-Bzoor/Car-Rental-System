using AutoMapper;

namespace Car_Rental.Web.Profiles
{
    public class CountriesStatusProfile : Profile
    {
        public CountriesStatusProfile()
        {
            CreateMap<Db.Entities.Countries, Models.Countries>();
        }
    }
}
