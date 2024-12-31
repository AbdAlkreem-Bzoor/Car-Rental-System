using AutoMapper;

namespace Car_Rental.Web.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<Db.Entities.User, Models.User>();
        }
    }
}
