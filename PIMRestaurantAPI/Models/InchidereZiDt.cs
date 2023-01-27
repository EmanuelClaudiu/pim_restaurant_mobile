using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class InchidereZiDt
{
    public long Id { get; set; }

    public long? NumarDts { get; set; }

    public DateTime? DataDts { get; set; }

    public long? IdgestiuneProductie { get; set; }

    public long? IdgestiuneDepozit { get; set; }

    public string? ActiuneStocuri { get; set; }

    public long? Transfer { get; set; }

    public bool? EfectuatTransfer { get; set; }

    public string? Info { get; set; }

    public virtual ICollection<InchidereZiproduseDt> InchidereZiproduseDts { get; } = new List<InchidereZiproduseDt>();
}
