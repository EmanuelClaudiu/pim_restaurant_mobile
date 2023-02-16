using PIMRestaurantAPI.DTOs;

namespace PIMRestaurantAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<MeseScaune, MasaDTO>();
            CreateMap<NomenclatorGrupa, GrupaDTO>();
            CreateMap<Produse, ProdusDTO>();
            CreateMap<Produse, BillItemDTO>();
            CreateMap<Utilizatori, UserDTO>();
        }
    }
}
