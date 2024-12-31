using AutoMapper;

namespace Car_Rental.Web.Profiles
{
    public class RentalStatusProfile : Profile
    {
        public RentalStatusProfile()
        {
            CreateMap<Db.Entities.RentalStatus, Models.RentalStatus>();
        }
    }
}
