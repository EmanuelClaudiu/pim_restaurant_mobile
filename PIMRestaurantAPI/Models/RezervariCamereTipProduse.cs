using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class RezervariCamereTipProduse
{
    public long Id { get; set; }

    public long? IdrezervareCamereTip { get; set; }

    public long? Idprodus { get; set; }

    public double? Cantitate { get; set; }

    public double? Pret { get; set; }

    public virtual RezervariCamereTip? IdrezervareCamereTipNavigation { get; set; }
}
