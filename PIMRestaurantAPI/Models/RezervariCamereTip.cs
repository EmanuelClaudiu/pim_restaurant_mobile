using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class RezervariCamereTip
{
    public long Id { get; set; }

    public string? Denumire { get; set; }

    public bool? CuValoare { get; set; }

    public bool? CuBilet { get; set; }

    public long? Idgestiune { get; set; }

    public virtual ICollection<RezervariCamereTipProduse> RezervariCamereTipProduses { get; } = new List<RezervariCamereTipProduse>();
}
