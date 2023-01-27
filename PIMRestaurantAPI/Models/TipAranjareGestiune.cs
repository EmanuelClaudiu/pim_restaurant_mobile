using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class TipAranjareGestiune
{
    public long Id { get; set; }

    public long? Idgestiune { get; set; }

    public string? Denumire { get; set; }

    public bool? Activ { get; set; }

    public virtual NomenclatorGestiuni? IdgestiuneNavigation { get; set; }
}
