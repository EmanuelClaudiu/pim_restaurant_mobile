using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class IesiriReceptie
{
    public long Id { get; set; }

    public long? IdprodusReceptie { get; set; }

    public long? Idiesire { get; set; }

    public long? Idgestiune { get; set; }

    public long? IdgestiuneDestinatie { get; set; }

    public long? Idprodus { get; set; }

    public double? Tva { get; set; }

    public double? Cantitate { get; set; }

    public double? PretAchizitie { get; set; }

    public double? PretVanzare { get; set; }

    public string? TipIesire { get; set; }

    public DateTime? Data { get; set; }

    public long? Iduser { get; set; }

    public string? MachineName { get; set; }

    public virtual ProduseReceptie? IdprodusReceptieNavigation { get; set; }
}
