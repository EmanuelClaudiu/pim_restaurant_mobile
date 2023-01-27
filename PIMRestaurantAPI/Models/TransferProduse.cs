using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class TransferProduse
{
    public long Id { get; set; }

    public long? Idtransfer { get; set; }

    public long? IdprodusReceptie { get; set; }

    public long? Idprodus { get; set; }

    public string? DenumireProdus { get; set; }

    public double? Tva { get; set; }

    public string? ContContabil { get; set; }

    public double? Cantitate { get; set; }

    public double? PretAchizitie { get; set; }

    public double? PretGestiune { get; set; }

    public double? ValoareAchizitie { get; set; }

    public double? ValoareGestiune { get; set; }

    public string? Um { get; set; }

    public string? Grupa { get; set; }

    public long? Iduser { get; set; }

    public string? MachineName { get; set; }

    public long? Idgestiune { get; set; }

    public DateTime? Data { get; set; }

    public bool? Adaugat { get; set; }

    public string? Observatii { get; set; }

    public double? PretGestiuneSursa { get; set; }

    public double? ValoareGestiuneSursa { get; set; }

    public virtual Transfer? IdtransferNavigation { get; set; }
}
