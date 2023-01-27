using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class ProdusePeMasaMnetiuni
{
    public long Id { get; set; }

    public long? Idprodus { get; set; }

    public string? Mentiune { get; set; }

    public bool? ComandaEfectuata { get; set; }

    public virtual ProdusePeMasa? IdprodusNavigation { get; set; }
}
