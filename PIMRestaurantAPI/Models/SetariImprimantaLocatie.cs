using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class SetariImprimantaLocatie
{
    public long Id { get; set; }

    public long? Idgestiune { get; set; }

    public long? Idlocatie { get; set; }

    public string? Imprimanta { get; set; }

    public bool? Grupat { get; set; }

    public virtual NomenclatorGestiuni? IdgestiuneNavigation { get; set; }
}
