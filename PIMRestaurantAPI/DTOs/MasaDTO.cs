using PIMRestaurantAPI.DTOs.Enums;

namespace PIMRestaurantAPI.DTOs
{
    public class MasaDTO
    {
        public long Id { get; set; }

        public long? Idsala { get; set; }

        public string? Name { get; set; }
        public bool? Occupied { get; set; }

        public long? AcumPeScaun { get; set; }
        public long? IdUser { get; set; } = null;
        public MasaStatus? Status { get; set; } = MasaStatus.LIBERA;
    }
}
