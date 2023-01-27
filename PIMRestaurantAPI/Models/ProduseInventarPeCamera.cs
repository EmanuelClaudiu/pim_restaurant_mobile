using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class ProduseInventarPeCamera
{
    public long Id { get; set; }

    public long? Idscaun { get; set; }

    public long? Idprodus { get; set; }

    public double? CantitatePeCamera { get; set; }

    public long? Idgestiune { get; set; }

    public virtual MeseScaune? IdscaunNavigation { get; set; }
}
