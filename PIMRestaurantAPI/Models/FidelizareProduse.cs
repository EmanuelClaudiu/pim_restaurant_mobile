using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class FidelizareProduse
{
    public long Id { get; set; }

    public long? IdfidelizareGrupe { get; set; }

    public long? Produs { get; set; }

    public double? Discount { get; set; }

    public double? PretNou { get; set; }

    public string? TipDiscount { get; set; }

    public virtual FidelizareGrupe? IdfidelizareGrupeNavigation { get; set; }
}
