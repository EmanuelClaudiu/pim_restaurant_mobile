using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class LayoutGrid
{
    public long Id { get; set; }

    public long? Iduser { get; set; }

    public string? TipRaport { get; set; }

    public string? NumeRaport { get; set; }

    public string? Layout { get; set; }

    public virtual Utilizatori? IduserNavigation { get; set; }
}
