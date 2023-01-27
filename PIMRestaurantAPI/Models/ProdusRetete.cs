using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class ProdusRetete
{
    public long Id { get; set; }

    public long? Idprodus { get; set; }

    public string? Tip { get; set; }

    public double? Per { get; set; }

    public string? Mod { get; set; }

    public double? Cantitate { get; set; }

    public long? Idmaterial { get; set; }

    public long? Descarcat { get; set; }

    public long? Idum { get; set; }

    public virtual Produse? IdprodusNavigation { get; set; }
}
