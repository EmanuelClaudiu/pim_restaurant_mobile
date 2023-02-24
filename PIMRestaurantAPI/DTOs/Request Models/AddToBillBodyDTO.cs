namespace PIMRestaurantAPI.DTOs.Request_Models
{
    public class AddToBillBodyDTO
    {
        public long Iduser { get; set; }
        public long? IdProdusCantitatePredefinita { get; set; }
        public string NumarComanda { get; set; }
    }
}
