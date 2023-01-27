using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class SpalatoriePretContract
{
    public long Id { get; set; }

    public long? IdspalatorieContract { get; set; }

    public long? Idprodus { get; set; }

    public double? Pret { get; set; }

    public double? Idgestiune { get; set; }

    public virtual SpalatorieContract? IdspalatorieContractNavigation { get; set; }
}
