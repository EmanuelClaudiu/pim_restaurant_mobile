using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class ProdusCantitatiPredefinite
{
    public long Id { get; set; }

    public long? Idprodus { get; set; }

    public double? CantitatePredefinita { get; set; }

    public string? Alias { get; set; }

    public virtual Produse? IdprodusNavigation { get; set; }
}
