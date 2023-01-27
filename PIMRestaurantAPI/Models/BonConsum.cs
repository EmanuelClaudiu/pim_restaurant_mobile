using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class BonConsum
{
    public long Id { get; set; }

    public DateTime? DataBonConsum { get; set; }

    public string? NumarBonConsum { get; set; }

    public string? SerieBonConsum { get; set; }

    public long? Idgestiune { get; set; }

    public double? Tva { get; set; }

    public bool? Finalizat { get; set; }

    public long? Idclient { get; set; }

    public long? Iduser { get; set; }

    public string? MachineName { get; set; }

    public string? Observatii { get; set; }

    public DateTime? DataCreareDocument { get; set; }

    public virtual ICollection<BonConsumProduse> BonConsumProduses { get; } = new List<BonConsumProduse>();
}
