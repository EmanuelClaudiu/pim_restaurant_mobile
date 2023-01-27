using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class StariAtasateCamera
{
    public long Id { get; set; }

    public long? Idstare { get; set; }

    public long? Idscaun { get; set; }

    public long? Idgestiune { get; set; }

    public virtual MeseScaune? IdscaunNavigation { get; set; }
}
