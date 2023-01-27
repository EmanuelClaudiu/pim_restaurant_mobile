using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class InchidereZi
{
    public long Id { get; set; }

    public long? Idgestiune { get; set; }

    public DateTime? DataZiInchisa { get; set; }

    public long? Iduser { get; set; }

    public string? MachineName { get; set; }

    public bool? Validata { get; set; }
}
