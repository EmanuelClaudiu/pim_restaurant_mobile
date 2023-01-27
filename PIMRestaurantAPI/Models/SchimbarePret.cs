using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class SchimbarePret
{
    public long Id { get; set; }

    public long? Idgestiune { get; set; }

    public DateTime? Data { get; set; }

    public string? Observatii { get; set; }

    public double? ValoareVeche { get; set; }

    public double? ValoareNoua { get; set; }

    public double? Diferenta { get; set; }

    public string? Tip { get; set; }

    public virtual ICollection<SchimbarePretProduse> SchimbarePretProduses { get; } = new List<SchimbarePretProduse>();
}
