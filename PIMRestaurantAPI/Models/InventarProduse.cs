using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class InventarProduse
{
    public long Id { get; set; }

    public long? Idinventar { get; set; }

    public string? DenumireProdus { get; set; }

    public string? Um { get; set; }

    public double? StocFinal { get; set; }

    public double? CantitateFaptica { get; set; }

    public double? CantitateDiferenta { get; set; }

    public virtual Inventar? IdinventarNavigation { get; set; }
}
