using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class FidelizareGrupe
{
    public long Id { get; set; }

    public long? Idgestiune { get; set; }

    public string? Denumire { get; set; }

    public double? Discount { get; set; }

    public virtual ICollection<FidelizareProduse> FidelizareProduses { get; } = new List<FidelizareProduse>();

    public virtual NomenclatorGestiuni? IdgestiuneNavigation { get; set; }
}
