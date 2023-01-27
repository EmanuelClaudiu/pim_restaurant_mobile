using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class ProduseReceptieSchimbarePret
{
    public long Id { get; set; }

    public long? IdprodusReceptie { get; set; }

    public DateTime? Data { get; set; }

    public double? Cantitate { get; set; }

    public double? PretVechi { get; set; }

    public double? PretNou { get; set; }

    public long? Idgestiune { get; set; }

    public virtual ProduseReceptie? IdprodusReceptieNavigation { get; set; }
}
