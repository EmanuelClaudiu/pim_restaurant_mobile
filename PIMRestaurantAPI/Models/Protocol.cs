using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class Protocol
{
    public long Id { get; set; }

    public string? Denumire { get; set; }

    public bool? Activ { get; set; }
}
