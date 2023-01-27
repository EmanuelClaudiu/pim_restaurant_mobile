using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class ReceptiePlati
{
    public long Id { get; set; }

    public long? IdcasaBanca { get; set; }

    public long? NumarDocument { get; set; }

    public DateTime? DataDocument { get; set; }

    public double? Suma { get; set; }

    public double? Rest { get; set; }

    public string? Utilizator { get; set; }

    public string? Serie { get; set; }

    public long? Idfurnizor { get; set; }

    public string? Observatii { get; set; }

    public long? Idgestiune { get; set; }

    public virtual ICollection<ReceptiePlatiAchitari> ReceptiePlatiAchitaris { get; } = new List<ReceptiePlatiAchitari>();
}
