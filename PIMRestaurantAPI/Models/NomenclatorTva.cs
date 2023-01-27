using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NomenclatorTva
{
    public long Id { get; set; }

    public double? Denumire { get; set; }

    public string? GrupaTva { get; set; }
}
