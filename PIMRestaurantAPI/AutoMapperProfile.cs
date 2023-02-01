using PIMRestaurantAPI.DTOs;

namespace PIMRestaurantAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<MeseScaune, MasaDTO>();
        }
    }
}
