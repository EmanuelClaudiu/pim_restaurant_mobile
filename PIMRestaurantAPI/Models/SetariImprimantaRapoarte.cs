using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class SetariImprimantaRapoarte
{
    public long Id { get; set; }

    public long? Idgestiune { get; set; }

    public string? Imprimanta { get; set; }

    public virtual NomenclatorGestiuni? IdgestiuneNavigation { get; set; }
}
