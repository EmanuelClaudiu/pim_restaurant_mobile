using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class BonConsumProduse
{
    public long Id { get; set; }

    public long? IdbonConsum { get; set; }

    public long? Idprodus { get; set; }

    public long? IdprodusReceptie { get; set; }

    public string? DenumireProdus { get; set; }

    public double? Tva { get; set; }

    public double? Cantitate { get; set; }

    public double? PretAchizitie { get; set; }

    public double? PretGestiune { get; set; }

    public double? ValoareAchizitie { get; set; }

    public double? ValoareGestiune { get; set; }

    public string? Um { get; set; }

    public string? Grupa { get; set; }

    public string? ContContabil { get; set; }

    public long? Iduser { get; set; }

    public string? MachineName { get; set; }

    public long? Idgestiune { get; set; }

    public DateTime? Data { get; set; }

    public bool? Adaugat { get; set; }

    public string? Observatii { get; set; }

    public virtual BonConsum? IdbonConsumNavigation { get; set; }
}
