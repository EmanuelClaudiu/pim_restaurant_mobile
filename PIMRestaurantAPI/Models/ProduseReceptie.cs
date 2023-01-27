using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class ProduseReceptie
{
    public long Id { get; set; }

    public long? Idreceptie { get; set; }

    public long? Idprodus { get; set; }

    public double? Cantitate { get; set; }

    public double? PretAchizitie { get; set; }

    public double? PretGestiune { get; set; }

    public string? Observatii { get; set; }

    public double? Adaos { get; set; }

    public double? Discount { get; set; }

    public double? Tva { get; set; }

    public string? Um { get; set; }

    public string? Grupa { get; set; }

    public string? ContContabil { get; set; }

    public long? Iduser { get; set; }

    public string? MachineName { get; set; }

    public long? Idgestiune { get; set; }

    public double? ValoareAchizitie { get; set; }

    public double? ValoareGestiune { get; set; }

    public double? PretAchizitieIntreg { get; set; }

    public double? ValoareTvaachizitie { get; set; }

    public double? Tvaneexigibil { get; set; }

    public double? AdaosComercial { get; set; }

    public double? CantitateDisponibila { get; set; }

    public DateTime? DataReceptie { get; set; }

    public bool? Finalizat { get; set; }

    public long? IdprodusTransfer { get; set; }

    public double? PretGestiuneInitial { get; set; }

    public double? Tvainitial { get; set; }

    public virtual Receptii? IdreceptieNavigation { get; set; }

    public virtual ICollection<IesiriReceptie> IesiriRecepties { get; } = new List<IesiriReceptie>();

    public virtual ICollection<ProduseReceptieSchimbarePret> ProduseReceptieSchimbarePrets { get; } = new List<ProduseReceptieSchimbarePret>();
}
