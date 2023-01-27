using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class PretProdusGestiune
{
    public long Id { get; set; }

    public long? Idprodus { get; set; }

    public long? Idgensiune { get; set; }

    public double? PretCumparare { get; set; }

    public double? PretVanzare { get; set; }

    public double? StocLimita { get; set; }

    public bool? Activ { get; set; }

    public virtual NomenclatorGestiuni? IdgensiuneNavigation { get; set; }

    public virtual Produse? IdprodusNavigation { get; set; }
}
