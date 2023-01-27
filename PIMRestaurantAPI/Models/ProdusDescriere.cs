using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class ProdusDescriere
{
    public long Id { get; set; }

    public long? Idprodus { get; set; }

    public string? Descriere { get; set; }

    public virtual Produse? IdprodusNavigation { get; set; }
}
