using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class Inventar
{
    public long Id { get; set; }

    public long? Iduser { get; set; }

    public string? Utilizator { get; set; }

    public string? Gestiunea { get; set; }

    public DateTime? StocLaData { get; set; }

    public DateTime? DataSalvareInventar { get; set; }

    public string? MeseNeinchise { get; set; }

    public string? FaraFormaPlata { get; set; }

    public string? InchideriZi { get; set; }

    public virtual ICollection<InventarProduse> InventarProduses { get; } = new List<InventarProduse>();
}
