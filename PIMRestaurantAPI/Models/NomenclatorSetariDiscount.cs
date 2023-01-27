using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NomenclatorSetariDiscount
{
    public long Id { get; set; }

    public long? Idgestiune { get; set; }

    public double? ProcentDiscount { get; set; }

    public string? ParolaDiscount { get; set; }

    public string? TipDiscount { get; set; }

    public bool? HappyHour { get; set; }

    public virtual NomenclatorGestiuni? IdgestiuneNavigation { get; set; }
}
