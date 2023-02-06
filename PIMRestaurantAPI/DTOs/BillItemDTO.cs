namespace PIMRestaurantAPI.DTOs
{
    public class BillItemDTO
    {
        public long Id { get; set; }
        public ProdusDTO Product { get; set; }
        public long? idTable { get; set; }
        public double? Quantity { get; set; }
    }
}
