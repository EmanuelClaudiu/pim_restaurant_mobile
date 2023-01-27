using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class SchimbarePretProduse
{
    public long Id { get; set; }

    public long? IdschimbarePret { get; set; }

    public long? Idprodus { get; set; }

    public double? PretNou { get; set; }

    public double? Tvanou { get; set; }

    public double? PretGestiune { get; set; }

    public double? Tva { get; set; }

    public double? Cantitate { get; set; }

    public virtual SchimbarePret? IdschimbarePretNavigation { get; set; }
}
