using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class ProduseCoduriBare
{
    public long Id { get; set; }

    public long? Idprodus { get; set; }

    public string? CodaBare { get; set; }

    public virtual Produse? IdprodusNavigation { get; set; }
}
