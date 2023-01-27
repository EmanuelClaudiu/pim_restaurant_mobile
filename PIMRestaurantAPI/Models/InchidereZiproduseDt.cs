using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class InchidereZiproduseDt
{
    public long Id { get; set; }

    public long? IdinchidereZiDts { get; set; }

    public long? Idprodus { get; set; }

    public double? Cantitate { get; set; }

    public double? Pret { get; set; }

    public string? Tip { get; set; }

    public double? Tva { get; set; }

    public double? CantitateDts { get; set; }

    public virtual InchidereZiDt? IdinchidereZiDtsNavigation { get; set; }
}
