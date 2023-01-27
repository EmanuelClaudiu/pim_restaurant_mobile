using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NomenclatorProduseHappyHour
{
    public long Id { get; set; }

    public long? IdnomenclatorHappyHour { get; set; }

    public long? Produs { get; set; }

    public double? Discount { get; set; }

    public double? PretNou { get; set; }

    public string? TipDiscount { get; set; }

    public virtual NomenclatorHappyHour? IdnomenclatorHappyHourNavigation { get; set; }
}
