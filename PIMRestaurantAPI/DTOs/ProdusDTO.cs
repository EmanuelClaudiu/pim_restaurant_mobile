namespace PIMRestaurantAPI.DTOs
{
    public class ProdusDTO
    {
        public long Id { get; set; }

        public string? Categorie { get; set; }

        public string? Denumire { get; set; }

        public long? Grupa { get; set; }

        public long? Locatie { get; set; }

        public double? Pret { get; set; }

        public List<CantitatePredefinitaDTO>? CantitatiPredefinite { get; set; }
    }
}
